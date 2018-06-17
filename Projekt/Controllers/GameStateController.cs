using System.Linq;
using CookiClickerEF.Models;
using CookiClickerEF.Context;
using Microsoft.AspNetCore.Mvc;
using Projekt.Services;
using CookiClickerEF.Models.Transaction;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Projekt.Controllers
{
    public class GameStateController : BaseController
    {
        private readonly GameStateValidation _validator;

        public GameStateController(CookieClickerContext context, GameStateValidation validator) : base(context)
        {
            _validator = validator;
        }

        private List<GameStateUpgradeData> GetAllUpgrades(GameStateData state)
        {
            List<GameStateUpgradeData> upgrades = this._context.GameStateUpgrades
                .Where(model => model.GameStateId == state.Id)
                .Include(model => model.Upgrade).ToList();

            if (state.ParentId != null)
            {
                GameStateData parent = this._context.GameStates.First(gameState => gameState.Id == state.ParentId);
                upgrades.AddRange(GetAllUpgrades(parent));
            }

            return upgrades;
        }

        [HttpGet]
        public JsonResult Get(int id)
        {
            GameStateData stateData = this._context.GameStates.AsNoTracking()
                .First((GameStateData arg) => arg.Id == id);


            List<GameStateUpgradeData> allUpgrades = GetAllUpgrades(stateData);

            allUpgrades = allUpgrades.GroupBy(model => model.Upgrade.Id).Select(groupedStateUpgrades => new GameStateUpgradeData()
            {
                Upgrade = groupedStateUpgrades.First().Upgrade,
                Amount = groupedStateUpgrades.Sum(gsu => gsu.Amount)
            }).ToList();

            stateData.GameStateUpgrades = allUpgrades;

            GameState state = (GameState)stateData;


            return Json(state);
        }

        [HttpGet]
        public JsonResult GetLast()
        {
            GameStateData stateData = this._context.GameStates.OrderByDescending((GameStateData arg) => arg.CreatedAt).FirstOrDefault();

            GameState state = (GameState)stateData;

            if(state != null)
                state.Upgrades.AddRange(GetAllUpgrades(stateData).ConvertAll(upgradeData => (Upgrade)upgradeData));

            return Json(state);
        }

        [HttpPost]
        public IActionResult Save(GameState state)
        {
            if (!this._validator.AreUpgradesValid(state))
            {
                // TODO ErrorMessage
                return View();
            }

            this._context.Add(state);
            this._context.SaveChanges();

            return View();
        }
    }
}

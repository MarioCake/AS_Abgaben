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

        private List<UpgradeData> GetAllUpgrades(GameStateData state)
        {
            List<UpgradeData> upgrades = this._context.GameStateUpgrades
                .Where(model => model.GameStateId == state.Id)
                .Include(model => model.Upgrade)
                .Select(model => model.Upgrade).ToList();

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

            GameState state = (GameState)stateData;

            state.Upgrades.AddRange(GetAllUpgrades(stateData).ConvertAll(upgradeData => (Upgrade)upgradeData));


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

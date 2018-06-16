using System.Linq;
using CookiClickerEF.Models;
using CookiClickerEF.Context;
using Microsoft.AspNetCore.Mvc;
using Projekt.Services;

namespace Projekt.Controllers
{
    public class GameStateController : BaseController
    {
        private readonly GameStateValidation _validator;

        public GameStateController(CookieClickerContext context, GameStateValidation validator) : base(context)
        {
            _validator = validator;
        }

        public JsonResult Get(int id)
        {
            return Json(this._context.GameStates.First((GameState arg) => arg.Id == id));
        }

        public JsonResult GetLast()
        {
            return Json(this._context.GameStates.OrderByDescending((GameState arg) => arg.CreatedAt).FirstOrDefault());
        }

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

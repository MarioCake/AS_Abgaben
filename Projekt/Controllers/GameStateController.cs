using System.Linq;
using CookiClickerEF.Models;
using CookiClickerEF.Context;
using Microsoft.AspNetCore.Mvc;
using Projekt.Services;

namespace Projekt.Controllers
{
    public class GameStateController : Controller
    {
        private CookieClickerContext context;
        private GameStateValidation validator;

        public GameStateController()
        {
            this.context = new CookieClickerContext();
            this.validator = new GameStateValidation();
        }

        public JsonResult Get(int id)
        {
            return Json(this.context.GameStates.First((GameState arg) => arg.Id == id));
        }

        public JsonResult GetLast()
        {
            return Json(this.context.GameStates.OrderByDescending((GameState arg) => arg.CreatedAt).FirstOrDefault());
        }

        public IActionResult Save(GameState state)
        {
            if (!this.validator.AreUpgradesValid(state))
            {
                // TODO ErrorMessage
                return View();
            }

            this.context.Add(state);
            this.context.SaveChanges();

            return View();
        }
    }
}

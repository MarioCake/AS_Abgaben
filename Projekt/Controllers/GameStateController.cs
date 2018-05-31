using System.Linq;
using CookiClickerEF.Models;
using CookiClickerEF.Context;
using Microsoft.AspNetCore.Mvc;

namespace Projekt.Controllers
{
    public class GameStateController : Controller
    {
        private CookieClickerContext context;

        public GameStateController()
        {
            this.context = new CookieClickerContext();
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
            state.Id;
            this.context.Add(state);
            this.context.SaveChanges();

            return View();
        }
    }
}

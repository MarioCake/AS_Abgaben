using CookiClickerEF.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Controllers
{
    public class BaseController : Controller
    {
        protected readonly CookieClickerContext _context;

        public BaseController(CookieClickerContext context)
        {
            _context = context;
        }
    }
}

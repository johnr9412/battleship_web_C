using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace battleship_web_C.Controllers
{
    public class LocalPVPController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Html5Site.Controllers
{
    public class Chapter2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
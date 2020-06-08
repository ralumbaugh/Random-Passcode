using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using RandomPasscode.Models;

namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("NumberOfClicks") == null)
            {
                HttpContext.Session.SetInt32("NumberOfClicks",0);
            }
            int? Clicked = HttpContext.Session.GetInt32("NumberOfClicks");
            IndexView MyView = new IndexView((int)Clicked);
            return View("Index", MyView);
        }

        [HttpPost("PressButton")]
        public IActionResult Click()
        {
            int? Clicked = HttpContext.Session.GetInt32("NumberOfClicks");
            int newClicked = (int)Clicked + 1;
            HttpContext.Session.SetInt32("NumberOfClicks", newClicked);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

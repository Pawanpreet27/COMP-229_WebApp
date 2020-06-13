using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp_Assignment1.Models;

namespace WebApp_Assignment1.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
            return View("Home");
        }

        [HttpGet]
        public ViewResult ContactMe()
        {
            return View();
        }



        [HttpPost]
        public ViewResult ContactMe(UResponse uResponse)
        {
            if (ModelState.IsValid) { 
                Repository.AddResponse(uResponse);
                return View("ThanksUI", uResponse);
            }
            else
            {
                return View();
            }
        }


        public ViewResult Portfolio()
        {
            return View();
        }

        public ViewResult ListofEntries()
        {
            return View(Repository.GetResponses());
        }
    }
}

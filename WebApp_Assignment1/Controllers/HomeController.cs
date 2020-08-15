using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using WebApp_Assignment1.Models;
using System;
using System.Linq;

namespace WebApp_Assignment1.Controllers
{
  
    public class HomeController : Controller
    {

        ApplicationDbContext context;

        public HomeController(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public ViewResult Index()
        {
            return View("Home");
        }

        public ViewResult Home() 
        {
            HomeModel homeModel = new HomeModel();
            {
                homeModel.Desscription = "I am a Full Stack Developer & Designer who has a knack for creatively solving problems. I have more than 2+ years of experience in native Mobile Application development. I have experience working with large and small companies to create, fix and maintain apps for them.";
                homeModel.ImageName = "arnold-francisca-3uA-fTfb3Es-unsplash.jpg";
                homeModel.Name = "My Blog";
            };
            return View(homeModel);
        }


        [HttpGet]
        public ViewResult ContactMe()
        {
            return View();
        }

        [HttpPost]
        public ViewResult ContactMe(UResponse uResponse)
        {
            EFUResponseRepository repository = new EFUResponseRepository(context);
            if (ModelState.IsValid) {
                repository.SaveProduct(uResponse);
                return View("ThanksUI", uResponse);
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Delete(int responseId)
        {
            EFUResponseRepository repository = new EFUResponseRepository(context);
            if (this.User.Identity.IsAuthenticated)
            {
                UResponse deletedProduct = repository.DeleteProduct(responseId);
                if (deletedProduct != null)
                {
                    TempData["message"] = $"{deletedProduct.Name} was deleted";
                }
                return RedirectToAction("ListofEntries");
            }
            else
            {
                return RedirectToAction("ErrorMsg");
            }

        }

     
        public ViewResult ListofEntries()
        {
            EFUResponseRepository repository = new EFUResponseRepository(context);
            return View(repository.uResponses);
        }

      
        public ViewResult EditContactInfo(int responseId)
        {
            EFUResponseRepository repository = new EFUResponseRepository(context);
            return View(repository.uResponses.FirstOrDefault(p => p.UResponsesID == responseId));
        }

      
        [HttpPost]
        public IActionResult EditContactInfo(UResponse response)
        {
            EFUResponseRepository repository = new EFUResponseRepository(context);
            if (this.User.Identity.IsAuthenticated)
            {

                if (ModelState.IsValid)
                {
                    repository.SaveProduct(response);
                    TempData["message"] = $"{response.Name} has been saved";
                    return RedirectToAction("ListofEntries");
                }
                else
                {
                    return View(response);
                }
        }
            else
            {
                return RedirectToAction("ErrorMsg");
    }
        }

        public ViewResult Portfolio()
        {
            return View();
        }

       
        public ViewResult Privacy()
        {
            return View();
        }

        public ViewResult ErrorMsg()
        {
            return View();
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using WebApp_Assignment1.Models;

namespace WebApp_Assignment1.Controllers
{
    public class HomeController : Controller
    {

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

        public ViewResult Privacy()
        {
            return View();
        }
    }
}

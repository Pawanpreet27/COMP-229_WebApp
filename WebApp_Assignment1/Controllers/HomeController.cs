using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using WebApp_Assignment1.Models;

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

        public ViewResult ListofEntries()
        {
            EFUResponseRepository repository = new EFUResponseRepository(context);
            return View(repository.uResponses);
        }

        public ViewResult Portfolio()
        {
            return View();
        }

       
        public ViewResult Privacy()
        {
            return View();
        }

       
    }
}

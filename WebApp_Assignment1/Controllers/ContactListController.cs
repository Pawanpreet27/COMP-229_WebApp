using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp_Assignment1.Models;

namespace WebApp_Assignment1.Controllers
{
    public class ContactListController : Controller
    {

        private EFUResponseRepository repository;
        public ViewResult Index()
        {
            return View("Home");
        }

        public ContactListController(EFUResponseRepository repo)
        {
            repository = repo;
        }
       
        public ViewResult ListofEntries()
        {
            return View(repository.uResponses);
        }

    }
}

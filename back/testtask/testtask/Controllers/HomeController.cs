using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using testtask.Data;
using testtask.Models;
using testtask.Models.PersonModel;
using testtask.Repository;

namespace testtask.Controllers
{
    public class HomeController : Controller
    {
        private readonly HomeRepository _homeRepository;

        public HomeController(HomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Person person)
        {
            if (ModelState.IsValid)
            {
               _homeRepository.addPerson(person);
                return RedirectToAction("Index");
            }
            return View("Index", person); 
        }

    }
}

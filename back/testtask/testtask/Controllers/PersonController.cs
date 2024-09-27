using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testtask.Data;
using testtask.Repository;

namespace testtask.Controllers
{
    public class PersonController : Controller
    {
        private readonly PersonRepository _personRepository;
        private readonly DataContext _dataContext;

        public PersonController(PersonRepository personRepository, DataContext dataContext)
        {
            _personRepository = personRepository;
            _dataContext = dataContext;
        }

        public IActionResult Index(string sortOrder, string searchString)
        {
            ViewBag.NameSortParam = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParam = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.SalarySortParam = sortOrder == "Salary" ? "salary_desc" : "Salary";
            ViewBag.MarriedSortParam = sortOrder == "Married" ? "no_married" : "Married";
            ViewBag.PhoneSortParam = sortOrder == "Phone" ? "phone_desc" : "Phone";

            var persons = from p in _dataContext.People select p;


            if (!String.IsNullOrEmpty(searchString))
            {
                persons = persons.Where(p => p.Name.Contains(searchString) || p.Phone.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    persons = persons.OrderByDescending(p => p.Name);
                    break;
                case "Date":
                    persons = persons.OrderBy(p => p.DateOfBirth);
                    break;
                case "date_desc":
                    persons = persons.OrderByDescending(p => p.DateOfBirth);
                    break;
                case "Salary":
                    persons = persons.OrderBy(p => p.Salary);
                    break;
                case "salary_desc":
                    persons = persons.OrderByDescending(p => p.Salary);
                    break;
                case "Married":
                    persons = persons.OrderByDescending(p => p.Married);
                    break;
                case "no_married":
                    persons = persons.OrderBy(p =>p.Married);
                    break;
                case "Phone":
                    persons = persons.OrderByDescending(p => p.Phone);
                    break;
                case "phone_desc":
                    persons = persons.OrderBy(p => p.Phone);
                    break;
                default:
                    persons = persons.OrderBy(p => p.Name);
                    break;
            }

            return View(persons.ToList());
        }


        public async Task<IActionResult> Delete(int id)
        {
            await _personRepository.deletePerson(id);
            return RedirectToAction("Index");
        }
    }
}


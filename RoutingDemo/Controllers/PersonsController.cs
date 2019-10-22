using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoutingDemo.Models;

namespace RoutingDemo.Controllers
{
    public class PersonsController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Person> persons = GetPersons();
            return View(persons);
        }

        [Route("{firstName}-{lastName}-{id:int}")]
        public IActionResult Details(string firstName, string lastName, int id)
        {
            var p = GetPersons().FirstOrDefault(x => x.Id == id);
            if (p != null) return Ok(p);

            return NotFound();
        }
        private IEnumerable<Person> GetPersons()
        {
            var persons = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    FirstName = "Jörgen",
                    LastName = "Ågren"
                },
                new Person
                {
                    Id = 2,
                    FirstName = "Örjan",
                    LastName = "Fältskog"
                }
            };
            return persons;
        }
    }
}
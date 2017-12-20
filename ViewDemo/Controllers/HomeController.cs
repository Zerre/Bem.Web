using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewDemo.Models;

namespace ViewDemo.Controllers
{
    public class HomeController : Controller
    {
        private List<Person> GetPerson()
        {
            return new List<Person>
            {
                new Person{Name="Orhan", IdentityNumber="12345678912"},
                  new Person{Name="Ahmet", IdentityNumber="12345678912"},
                    new Person{Name="Zekiye", IdentityNumber="12345678912"},
                    new Person{Name="Osman", IdentityNumber="12345678912"},
                    new Person{Name="Zekiye", IdentityNumber="12345678912"}
            };
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            ViewData.Add("baslik", "Hakkımızda");
            ViewBag.CalismaZamani= DateTime.Now;
            ViewBag.LayoutPath = "~/Views/Shared/sublyout.cshtml";
            return View();
        }

        public ActionResult ListPerson()
        {
            var people = GetPerson();

            return View(people);
        }

        public ActionResult ListPersonStartWithO()
        {
            var people = GetPerson().Where(p=> p.Name.StartsWith("O")).ToList();

            return View(people);
        }
    }
}
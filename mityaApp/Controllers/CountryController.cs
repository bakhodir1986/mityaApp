using mityaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mityaApp.Controllers
{
    public class CountryController : Controller
    {
        private List<CountryModel> countryModels = new List<CountryModel>();

        // GET: Country
        public ActionResult Index()
        {
            var country = new CountryModel();
            country.Id = 1;
            country.Name = "Россия";
            country.Code = "RU";

            countryModels.Add(country);

            var country2 = new CountryModel();
            country2.Id = 2;
            country2.Name = "Белорусь";
            country2.Code = "BY";

            countryModels.Add(country2);

            return View(countryModels);
        }

        // GET: Country/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Country/Create
        public ActionResult Create()
        {
            var country = new CountryModel();

            return View(country);
        }

        // POST: Country/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Country/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Country/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Country/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Country/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

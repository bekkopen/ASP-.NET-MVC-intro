﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCintro.Models;

namespace MVCintro.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Show(int id = 1)
        {
            var model = new PersonModel(id, "Nils", "Jensen", "9161166")
            {
                DateOfBirth = new DateTime(1987,06,06),
                IdentityNumber = "12345678910"
            };

            return View(model);
        }


        [HttpPost]
        public ActionResult Create(PersonModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Show", model);
            }
            return View("Index", model);
        }
    }
}
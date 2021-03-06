﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Mvc.Rendering;
using League.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace League.Controllers
{
    public class HomeController : Controller
    {
        private LeagueContext db = new LeagueContext();
        public IActionResult Index()
        {
            Division myDivision = new Division();
            ModelView newModelView = new ModelView
            {
                divisionList = db.Divisions.ToList(),
                divisionModel = myDivision
            };

            return View(newModelView);
        }

        [HttpPost]
        public ActionResult Create(Division division)
        {

            db.Divisions.Add(division);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}

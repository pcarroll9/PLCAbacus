/*
 * Author: Peter Carroll
 * Purpose: This controller renders the views for Index, about and contact
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyAbacus.Models;

namespace MyAbacus.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult PerformCalculation(AbacusViewModel model)
        {
            if(ModelState.IsValid)
            {
                var abucusModel = new AbacusModel(model.Number1, model.Number2);
                model.Sum = abucusModel.Sum;
            }
                        
            return View("Index", model);
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = new AbacusViewModel();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
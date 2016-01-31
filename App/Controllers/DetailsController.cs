using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using App.DAL;
using App.Models;

namespace App.Controllers
{
    public class DetailsController : Controller
    {
        private AppContext db = new AppContext();

        [HttpPost]
        public ActionResult planet(int? planetName )
        {
            if (planetName == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Details planet = db.Details.Find(planetName);
            if (planet == null)
            {
                return HttpNotFound();
            }
            ViewBag.Planet = planet.name;
            return View(planet);
        }
        [HttpPost]
        public ActionResult planet2(int? planetName)
        {
            if (planetName == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ViewBag.ID = planetName;
            return View();
        }


    }
}

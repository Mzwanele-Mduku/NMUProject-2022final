
using Innovators.Data;
using Innovators.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Web;
using System.Threading.Tasks;
using System.Text;


namespace Innovators.Controllers
{
    public class SubController : Controller
    {
        private readonly AppDbContext _db;
        public SubController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sub()
        {
            return View();
        }
        public IActionResult Cal()
        {

            return View();
        }

        public IActionResult AssignLecturers()
        {
            return View();
        }


        //Civil Engineering

        //[HttpPost]
        //[HttpGet]
        public IActionResult CivilEngineering()
        {
            IEnumerable<CivilEngineering> objList = _db.civilEngineering;
            return View(objList);
        }
        [HttpGet]
        public IActionResult StudentProgress()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CivilEngineering(CivilEngineering obj)
        {
            if (ModelState.IsValid)//Checks to see if all the required fields have been met.
            {
                _db.civilEngineering.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("CivilEngineering");
            }
            return View(obj);
        }

        //Information Technology
        public IActionResult InformationTechnology()
        {
            IEnumerable<InformationTechnology> objList = _db.informationTechnology;
            return View(objList);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult InformationTechnology(InformationTechnology obj)
        {
            if (ModelState.IsValid)//Checks to see if all the required fields have been met.
            {
                _db.informationTechnology.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("InformationTechnology");
            }
            return View(obj);
        }
        //Report
        public IActionResult Report()
        {
            return View();
        }


    }
}

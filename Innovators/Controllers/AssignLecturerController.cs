using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Innovators.Models;
using Innovators.Data;


namespace Innovators.Controllers
{
    public class AssignLecturerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly AppDbContext _db;
        public AssignLecturerController(AppDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult AssignLecturerDisplay()
        {
            IEnumerable<AssignLecturer> objList = _db.assignLecturers;
            return View(objList);
        }
        [HttpPost]
        public IActionResult AssignLecturerDisplay(AssignLecturer obj)
        {
            if (ModelState.IsValid)
            {
                _db.assignLecturers.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("AssignLecturerDisplay");
            }
            return View(obj);
        }
        public IActionResult UpdateLecturer(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.assignLecturers.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateLecturer(AssignLecturer obj)
        {
            _db.assignLecturers.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("AssignLecturerDisplay");
        }
        public IActionResult Update()
        {
            return View();
        }
    }
}


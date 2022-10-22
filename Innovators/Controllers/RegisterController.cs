using Innovators.Data;
using Innovators.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Innovators.Controllers
{
    public class RegisterController : Controller
    {
        private readonly RegisterDbContext _db;

        public RegisterController(RegisterDbContext db)
        {
            _db = db;
        }
    
        public IActionResult Index()
        {
            IEnumerable<Register> obj = _db.Register; 

            return View(obj);
        }
        [HttpGet]
        public IActionResult CreateRegister()
        {
            return View();
        }

        public IActionResult Report()
        {
            IEnumerable<Register> obj = _db.Register;

            return View(obj);
        }
        [HttpPost]
        public IActionResult CreateRegister(Register obj)
        {
            if (ModelState.IsValid)//Checks to see if all the required fields have been met.
            {
                _db.Register.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }





        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Report(Register obj)
        //{
        //    _db.Register.Update(obj);
        //    _db.SaveChanges();
        //    return RedirectToAction("Index");

        //}

        //[HttpGet]
        //public IActionResult Report(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }

        //    var obj = _db.Register.Find(id);
        //    if (obj == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(obj);


        //}


    }
}

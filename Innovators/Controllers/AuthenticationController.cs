using Innovators.Data;
using Innovators.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Innovators.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly UserDbContext _db;
        public AuthenticationController(UserDbContext db)
        {
            _db = db;   

        }
        //[HttpGet]
        //public IActionResult Index()
        //{
        //    //List<SelectListItem> items = new List<SelectListItem>();
        //    //SelectListItem lecturer = new SelectListItem()
        //    //{ Text = "Lecturer", Value = "1", Selected = false };
        //    //SelectListItem student = new SelectListItem()
        //    //{ Text = "Student", Value = "2", Selected = false };
        //    //SelectListItem parent = new SelectListItem()
        //    //{ Text = "Parent", Value = "3", Selected = false };
        //    //items.Add(lecturer);
        //    //items.Add(student);
        //    //items.Add(parent);

        //    //if(value!=null)
        //    //{
        //    //    items.Where(i=>i.Value==value.ToString()).First().Selected=true;
        //    //}
        //    //ViewBag.roles = items;  
        //    return View();
        //}

       
        public IActionResult Index()
        {

            return View();


        }
        public IActionResult Success()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Users obj)
        {
            if (ModelState.IsValid)
            {
                _db.Users.Add(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();

        }


    }
}

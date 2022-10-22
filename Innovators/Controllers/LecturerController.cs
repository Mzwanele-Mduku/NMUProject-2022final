using Innovators.Data;
using Innovators.Migrations;
using Innovators.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Innovators.Controllers
{
    public class LecturerController : Controller
    {
        private readonly TaskDbContext _db;
       

        public LecturerController(TaskDbContext db)
        {
            _db = db;
        }
      
        //lending
        
        
       
        public IActionResult Index()
        {
            IEnumerable<Task> obj = _db.Task; //from database


            return View(obj);
           
        }
        [HttpGet]
        public IActionResult Login()
        {
            Users _users = new Users();
            return View(_users);
        }
        [HttpPost]
        public IActionResult Login(Users _users)
        {
            UserDbContext _db=new UserDbContext();  
           
           var status=_db.Users.Where(m=>m.Email==_users.Email && m.Password==_users.Password).FirstOrDefault();   
           if(status==null)
            {
                ViewBag.LoginStatus = 0;
            }
           else
            {
                return RedirectToAction("Success", "Lecturer");
            }
            return View(_db);
        }
        public IActionResult Success()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateTask(Task obj)
        {
            _db.Task.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
            
        }

        
        public IActionResult UpdateTask(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Task.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

            
        }



        [HttpPost]
        public IActionResult DeleteTask(int? id)
        {
            return View();
        }

        public IActionResult CreateTask(Task obj)
        {
            if (ModelState.IsValid)//Checks to see if all the required fields have been met.
            {
                _db.Task.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }


      
       
            
        
    }
}

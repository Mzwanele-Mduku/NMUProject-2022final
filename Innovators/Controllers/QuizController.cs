using Innovators.Data;
using Innovators.Migrations.QuizDb;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Innovators.Models;

namespace Innovators.Controllers
{
    public class QuizController : Controller
    {
        private readonly QuizModelDbContext _db;
        public QuizController(QuizModelDbContext db)
        {
            _db = db;
        }
        public IActionResult Live()
        {

            return View();
        }
        public IActionResult Memo()
        {

            IEnumerable<QuizModel> obj = _db.QuizModel;

            return View(obj);  
        }
        [HttpGet]
        public IActionResult QuizCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult QuizCreate(QuizModel obj)
        {
            if (ModelState.IsValid)//Checks to see if all the required fields have been met.
            {
                _db.QuizModel.Add(obj); 
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
            
        }

        public IActionResult Index()
        {
            IEnumerable<QuizModel> obj = _db.QuizModel;



            return View(obj);
        }
    }
}

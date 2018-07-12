using Microsoft.EntityFrameworkCore;
using Entity.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Entity.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context)
        {
            _context = context;
            _context.SaveChanges();
        }

        [HttpGet("")]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost("Home/addRev")]
        public IActionResult Create(Review rev)
        {
                            Console.WriteLine("Got inside Create");

            if (ModelState.IsValid)
            {

                Console.WriteLine(">>>>>>>>>>>>>> Form is valid");
                _context.Reviews.Add(rev);
                _context.SaveChanges();
                return RedirectToAction("ReviewsViews");
            }
            else
            {
                Console.WriteLine(">>>>>>>>>>>>>> Form Not valid");
                return View("Index");
            }
        }

        [HttpGet("ReviewsView")]
        public IActionResult ReviewsViews()
        {
            List<Review> allReviews = _context.Reviews.OrderByDescending(keySelector: rev =>rev.Review_Date).ToList();
            ViewBag.allRev = allReviews;

            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

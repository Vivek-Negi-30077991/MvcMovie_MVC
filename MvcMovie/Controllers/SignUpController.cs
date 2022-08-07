using Microsoft.AspNetCore.Mvc;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class SignUpController : Controller
    {
        private readonly MvcMovieContext _db;

        public SignUpController(MvcMovieContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index([Bind("UserId,Password,ConfirmPassword")] SignUp obj)
        {
            if (ModelState.IsValid)
            {
                _db.SignUp.Add(obj);
                _db.SaveChanges();
                return Redirect("/Home/Index");
            }
            return View(obj);
        }


        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LogIn(string UserId, string password)
        {
            var user = (from u in _db.SignUp
                        where u.UserId == UserId
                        select u).SingleOrDefault();
            if (user != null && user.Password == password)
            {
                return Redirect("/Movies/Index");
            }
            else
            {
                return Content("You are not registered ! Register first");
            }
        }
    }
}

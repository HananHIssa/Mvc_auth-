using Microsoft.AspNetCore.Mvc;
using WebApplication12.Data;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        public IActionResult Index()
        {
            var e = _context.Users.ToList();
            return View(e);
        }
        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult join (User u )
        {
            _context.Users.Add(u);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult LogIn()
        {
            return View();
        }
        public IActionResult logIn(User u)
        {
            if(_context.Users.Any())
            return RedirectToAction("Index");
            return View(u);
        }
    }
}

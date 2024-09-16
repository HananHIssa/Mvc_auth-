using Microsoft.AspNetCore.Mvc;
using WebApplication12.Data;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var x = _context.Employees.ToList();
            return View(x);
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Store(Employee e)
        {
            _context.Employees.Add(e);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            var x = _context.Employees.Find(id);
            return View(x);
        }
        public IActionResult Save(Employee e)
        {
            var x = _context.Employees.Find(e.Id);
            x.Name = e.Name;
            x.EnrollmentDate = e.EnrollmentDate;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var x = _context.Employees.Find(id);
            if (x != null)
                _context.Employees.Remove(x);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}


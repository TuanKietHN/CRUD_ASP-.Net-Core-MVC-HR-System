using Aptech.Contexts;
using Aptech.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aptech.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly HRMContext _context;

        public EmployeeController(HRMContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var employees = _context.Employees.ToList();
            return View(employees);
        }

        public IActionResult Detail(int id)
        {
            var employee = _context.Employees.Find(id);
            return View(employee);
        }

        public IActionResult Remove(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddNewEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Thông tin nhập vào không hợp lệ. Vui lòng kiểm tra lại!";
                return View(employee);
            }

            if (ModelState.IsValid)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();

                return RedirectToAction("Index", "Employee");
            }

            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            {
                Console.WriteLine(error.ErrorMessage);
            }

            return View(employee);
        }

    }

}

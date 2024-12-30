using Aptech.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace Aptech.Controllers
{
    public class AccountController : Controller
    {
        private readonly HRMContext _context;

        public AccountController(HRMContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = _context.HR_Users
                .SingleOrDefault(u => u.HR_Email == email && u.HR_Password == password);

            if (user == null)
            {
                TempData["ErrorMessage"] = "Incorrect login information, please check again.";
                return View();
            }

            return RedirectToAction("Index", "Employee");
        }

    }

}

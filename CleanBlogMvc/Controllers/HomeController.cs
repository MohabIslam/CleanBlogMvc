using CleanBlogCoreMvc.Models; // Assuming your ViewModel is here
using CleanBlogMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CleanBlogCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Home";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Title"] = "About";
            return View();
        }

        public IActionResult Post()
        {
            ViewData["Title"] = "Sample Post";
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            ViewData["Title"] = "Contact";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Process the form data (e.g., send email)
                // For now, just redirect to a success page or show a message
                TempData["SuccessMessage"] = "Your message has been sent!";
                return RedirectToAction("Contact");
            }
            ViewData["Title"] = "Contact";
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

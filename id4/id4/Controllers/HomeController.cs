using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using id4.Models;
using id4.Services;

namespace id4.Controllers
{
    public class HomeController : Controller
    {
        private IAdminService adminService;

        public HomeController(IAdminService _adminService)
        {
            adminService = _adminService;
        }
        public async Task<IActionResult> Index()
        {
            Admin m = await adminService.Get(a => a.Id == 1);
            return View(m);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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

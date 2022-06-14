using Microsoft.AspNetCore.Mvc;
using System;

namespace InAndOutMain.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(string id)
        {
            //return View();
            return Ok("Selected id is" + id);
        }
    }
}

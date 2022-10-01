using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GUI.Controllers
{
    public class SectionController : Controller
    {
        public IActionResult Index(string id)
        {
            ViewBag.courseId = id;
            return View();
        }
    }
}

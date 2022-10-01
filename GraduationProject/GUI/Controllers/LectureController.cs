using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GUI.Controllers
{
    public class LectureController : Controller
    {
        public IActionResult Index(string id)
        {
            ViewBag.sectionId = id;
            return View();
        }
    }
}

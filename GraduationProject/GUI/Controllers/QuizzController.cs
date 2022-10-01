using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GUI.Controllers
{
    public class QuizzController : Controller
    {
        public IActionResult Index(string id)
        {
            ViewBag.sectionId = id;
            ViewBag.questionId = null;
            return View();
        }
    }
}

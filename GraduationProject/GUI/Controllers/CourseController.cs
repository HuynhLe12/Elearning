using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GUI.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CourseWaiting()
        {
            return View();
        }

        public IActionResult CourseInstructor()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult CourseStudent()
        {
            return View();
        }

        public IActionResult Enrollment(Guid id)
        {
            ViewBag.studentId = id;
            return View();
        }
        
        public IActionResult CourseDetail(Guid id)
        {
            ViewBag.courseId = id;
            return View();
        }

        public IActionResult Category(Guid id)
        {
            ViewBag.cateId = id;
            return View();
        }

        public IActionResult CourseEnrolled(string id)
        {
            ViewBag.courseId = id;
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace GUI.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

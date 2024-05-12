using Microsoft.AspNetCore.Mvc;

namespace RecipeBlogProject.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace RecipeBlogProject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}

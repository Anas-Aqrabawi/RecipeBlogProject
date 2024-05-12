using Microsoft.AspNetCore.Mvc;

namespace RecipeBlogProject.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}

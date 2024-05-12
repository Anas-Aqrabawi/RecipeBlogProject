using Microsoft.AspNetCore.Mvc;
using RecipeBlogProject.Models;

namespace RecipeBlogProject.Controllers
{
    

    public class ChefController : Controller
    {
        private readonly ModelContext _context;

        public ChefController(ModelContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
           

            return View();
        }

        public IActionResult Tables()
        {
            ViewBag.categories = _context.Categories.ToList();
            ViewBag.recipes = _context.Recipes.ToList();

            return View();
        }
    }
}

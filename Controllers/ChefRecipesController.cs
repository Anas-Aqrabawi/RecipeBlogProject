using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecipeBlogProject.Models;

namespace RecipeBlogProject.Controllers
{
    public class ChefRecipesController : Controller
    {
        private readonly ModelContext _context;

        public ChefRecipesController(ModelContext context)
        {
            _context = context;
        }

        // GET: ChefRecipes
        public async Task<IActionResult> Index()
        {
            var modelContext = _context.Recipes.Include(r => r.Chef);
            return View(await modelContext.ToListAsync());
        }

       

        // GET: ChefRecipes/AddRecipe
        public IActionResult Create()
        {
            ViewData["ChefId"] = new SelectList(_context.Chefs, "Chefid", "Chefid");
            return View();
        }

        // POST: ChefRecipes/AddRecipe
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Recipeid,Receipename,Price,Ingredients,Isapproved,ChefId")] Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recipe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ChefId"] = new SelectList(_context.Chefs, "Chefid", "Chefid", recipe.ChefId);
            return View(recipe);
        }

        private bool RecipeExists(decimal id)
        {
          return (_context.Recipes?.Any(e => e.Recipeid == id)).GetValueOrDefault();
        }
    }
}

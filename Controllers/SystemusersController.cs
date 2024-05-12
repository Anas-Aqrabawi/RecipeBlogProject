using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using RecipeBlogProject.Common;
using RecipeBlogProject.Models;

namespace RecipeBlogProject.Controllers
{
    public class SystemusersController : Controller
    {
        private readonly ModelContext _context;

        public SystemusersController(ModelContext context)
        {
            _context = context;
        }

        // GET: Systemusers
        public async Task<IActionResult> Index()
        {
            var modelContext = _context.Systemusers.Include(s => s.Person).Include(s => s.Role);//.Where(s => s.RoleId ==  (int) Roles.RegisteredUser);
            return View(await modelContext.ToListAsync());
        }

        // GET: Systemusers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Systemusers == null)
            {
                return NotFound();
            }

            var systemuser = await _context.Systemusers
                .Include(s => s.Person)
                .Include(s => s.Role)
                .FirstOrDefaultAsync(m => m.Userid == id);
            if (systemuser == null)
            {
                return NotFound();
            }

            return View(systemuser);
        }

        // GET: Systemusers/Create
        public IActionResult Create()
        {
            ViewData["PersonId"] = new SelectList(_context.Persons, "Personid", "Personid");
            ViewData["RoleId"] = new SelectList(_context.Userroles, "Roleid", "Roleid");
            return View();
        }

        // POST: Systemusers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Userid,Username,Password,PersonId,RoleId")] Systemuser systemuser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(systemuser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonId"] = new SelectList(_context.Persons, "Personid", "Personid", systemuser.PersonId);
            ViewData["RoleId"] = new SelectList(_context.Userroles, "Roleid", "Roleid", systemuser.RoleId);
            return View(systemuser);
        }

        // GET: Systemusers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Systemusers == null)
            {
                return NotFound();
            }

            var systemuser = await _context.Systemusers.FindAsync(id);
            if (systemuser == null)
            {
                return NotFound();
            }
            ViewData["PersonId"] = new SelectList(_context.Persons, "Personid", "Personid", systemuser.PersonId);
            ViewData["RoleId"] = new SelectList(_context.Userroles, "Roleid", "Roleid", systemuser.RoleId);
            return View(systemuser);
        }

        // POST: Systemusers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Userid,Username,Password,PersonId,RoleId")] Systemuser systemuser)
        {
            if (id != systemuser.Userid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(systemuser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SystemuserExists(systemuser.Userid))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonId"] = new SelectList(_context.Persons, "Personid", "Personid", systemuser.PersonId);
            ViewData["RoleId"] = new SelectList(_context.Userroles, "Roleid", "Roleid", systemuser.RoleId);
            return View(systemuser);
        }

        // GET: Systemusers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Systemusers == null)
            {
                return NotFound();
            }

            var systemuser = await _context.Systemusers
                .Include(s => s.Person)
                .Include(s => s.Role)
                .FirstOrDefaultAsync(m => m.Userid == id);
            if (systemuser == null)
            {
                return NotFound();
            }

            return View(systemuser);
        }

        // POST: Systemusers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Systemusers == null)
            {
                return Problem("Entity set 'ModelContext.Systemusers'  is null.");
            }
            var systemuser = await _context.Systemusers.FindAsync(id);
            if (systemuser != null)
            {
                _context.Systemusers.Remove(systemuser);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SystemuserExists(int id)
        {
          return (_context.Systemusers?.Any(e => e.Userid == id)).GetValueOrDefault();
        }
    }
}

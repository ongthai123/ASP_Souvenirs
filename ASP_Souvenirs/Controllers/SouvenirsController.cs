using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP_Souvenirs.Data;
using ASP_Souvenirs.Models;
using Microsoft.AspNetCore.Authorization;

namespace ASP_Souvenirs.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SouvenirsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SouvenirsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Souvenirs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Sourvenirs.Include(s => s.Category).Include(s => s.Supplier);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Souvenirs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var souvenir = await _context.Sourvenirs
                .Include(s => s.Category)
                .Include(s => s.Supplier)
                .FirstOrDefaultAsync(m => m.SouvenirID == id);
            if (souvenir == null)
            {
                return NotFound();
            }

            return View(souvenir);
        }

        // GET: Souvenirs/Create
        public IActionResult Create()
        {
            ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryID", "Name");
            ViewData["SupplierID"] = new SelectList(_context.Suppliers, "SupplierID", "Name");
            return View();
        }

        // POST: Souvenirs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SouvenirID,Name,Description,Price,PathOfFile,CategoryID,SupplierID")] Souvenir souvenir)
        {
            if (ModelState.IsValid)
            {
                _context.Add(souvenir);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryID", "Name", souvenir.CategoryID);
            ViewData["SupplierID"] = new SelectList(_context.Suppliers, "SupplierID", "EmailAddress", souvenir.SupplierID);
            return View(souvenir);
        }

        // GET: Souvenirs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var souvenir = await _context.Sourvenirs.FindAsync(id);
            if (souvenir == null)
            {
                return NotFound();
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryID", "Name", souvenir.CategoryID);
            ViewData["SupplierID"] = new SelectList(_context.Suppliers, "SupplierID", "EmailAddress", souvenir.SupplierID);
            return View(souvenir);
        }

        // POST: Souvenirs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SouvenirID,Name,Description,Price,PathOfFile,CategoryID,SupplierID")] Souvenir souvenir)
        {
            if (id != souvenir.SouvenirID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(souvenir);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SouvenirExists(souvenir.SouvenirID))
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
            ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryID", "Name", souvenir.CategoryID);
            ViewData["SupplierID"] = new SelectList(_context.Suppliers, "SupplierID", "EmailAddress", souvenir.SupplierID);
            return View(souvenir);
        }

        // GET: Souvenirs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var souvenir = await _context.Sourvenirs
                .Include(s => s.Category)
                .Include(s => s.Supplier)
                .FirstOrDefaultAsync(m => m.SouvenirID == id);
            if (souvenir == null)
            {
                return NotFound();
            }

            return View(souvenir);
        }

        // POST: Souvenirs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var souvenir = await _context.Sourvenirs.FindAsync(id);
            _context.Sourvenirs.Remove(souvenir);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SouvenirExists(int id)
        {
            return _context.Sourvenirs.Any(e => e.SouvenirID == id);
        }
    }
}

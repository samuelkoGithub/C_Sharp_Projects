using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HymnStocks.Data;
using HymnStocks.Models;
using Microsoft.AspNetCore.Authorization;

namespace HymnStocks.Controllers
{
    public class HymnInfoesController : Controller
    {
        private readonly HymnStocksDBContext _context;

        public HymnInfoesController(HymnStocksDBContext context)
        {
            _context = context;
        }

        /*  Resume if the search box failure
        [Authorize]
        // GET: HymnInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.HymnInfo.ToListAsync());
        }
        */

        [Authorize]
        // GET: HymnInfoes
        public async Task<IActionResult> Index(string searchString)
        {
            if (_context.HymnInfo == null)
            {
                return Problem("Entity set 'HymnStockDBContext.HymnInfo' is null.");
            }

            var HymnInfo = from m in _context.HymnInfo
                           select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                // Use two info to search. 1) HymnName 2) CopyRight
                HymnInfo = HymnInfo.Where(k => k.HymnName!.ToUpper().Contains(searchString.ToUpper())
                            || k.CopyRight!.ToUpper().Contains(searchString.ToUpper()));
            }

            return View(HymnInfo);
        }
        
        /* Below codes are for Overload purpose */
        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }
   


        /* End of resume search box code */


        [Authorize]
        // GET: HymnInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hymnInfo = await _context.HymnInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hymnInfo == null)
            {
                return NotFound();
            }

            return View(hymnInfo);
        }

        [Authorize]
        // GET: HymnInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        // POST: HymnInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HymnName,CopyRight,HymnLanguage,PublishDate,Remarks")] HymnInfo hymnInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hymnInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hymnInfo);
        }

        [Authorize]
        // GET: HymnInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hymnInfo = await _context.HymnInfo.FindAsync(id);
            if (hymnInfo == null)
            {
                return NotFound();
            }
            return View(hymnInfo);
        }

        [Authorize]
        // POST: HymnInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,HymnName,CopyRight,HymnLanguage,PublishDate,Remarks")] HymnInfo hymnInfo)
        {
            if (id != hymnInfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hymnInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HymnInfoExists(hymnInfo.Id))
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
            return View(hymnInfo);
        }

        [Authorize]
        // GET: HymnInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hymnInfo = await _context.HymnInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hymnInfo == null)
            {
                return NotFound();
            }

            return View(hymnInfo);
        }

        [Authorize]
        // POST: HymnInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hymnInfo = await _context.HymnInfo.FindAsync(id);
            if (hymnInfo != null)
            {
                _context.HymnInfo.Remove(hymnInfo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HymnInfoExists(int id)
        {
            return _context.HymnInfo.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BaithiLTH0255.Models;
using MvcMovie.Data;
using BaithiLTH0255.Models.Process;

namespace BaithiLTH0255.Controllers
{
    public class LTHCau3Controller : Controller
    {
        private readonly MvcMovieContext _context;
        private StringProcess strPro = new StringProcess();

        public LTHCau3Controller(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: LTHCau3
        public async Task<IActionResult> Index()
        {
              return _context.LTHCau3 != null ? 
                          View(await _context.LTHCau3.ToListAsync()) :
                          Problem("Entity set 'MvcMovieContext.LTHCau3'  is null.");
        }

        // GET: LTHCau3/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.LTHCau3 == null)
            {
                return NotFound();
            }

            var lTHCau3 = await _context.LTHCau3
                .FirstOrDefaultAsync(m => m.Masinhvien == id);
            if (lTHCau3 == null)
            {
                return NotFound();
            }

            return View(lTHCau3);
        }

        // GET: Sinhvien/Create
        //Sinh mã tự động 
        //public IActionResult Create()
        // {
        //     return View();
        // }
        public IActionResult Create()
        {
            
            var IDdautien = "S1";
            var countAnh = _context.LTHCau3.Count();
            if (countAnh > 0)
            {
                var Masinhvien = _context.LTHCau3.OrderByDescending(m => m.Masinhvien).First().Masinhvien;
                IDdautien = strPro.AutoGenerateCode(Masinhvien);
            }
            ViewBag.newID = IDdautien;
            return View();
        }



        // POST: LTHCau3/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Masinhvien,Hoten,Malop")] LTHCau3 lTHCau3)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lTHCau3);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lTHCau3);
        }

        // GET: LTHCau3/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.LTHCau3 == null)
            {
                return NotFound();
            }

            var lTHCau3 = await _context.LTHCau3.FindAsync(id);
            if (lTHCau3 == null)
            {
                return NotFound();
            }
            return View(lTHCau3);
        }

        // POST: LTHCau3/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Masinhvien,Hoten,Malop")] LTHCau3 lTHCau3)
        {
            if (id != lTHCau3.Masinhvien)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lTHCau3);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LTHCau3Exists(lTHCau3.Masinhvien))
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
            return View(lTHCau3);
        }

        // GET: LTHCau3/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.LTHCau3 == null)
            {
                return NotFound();
            }

            var lTHCau3 = await _context.LTHCau3
                .FirstOrDefaultAsync(m => m.Masinhvien == id);
            if (lTHCau3 == null)
            {
                return NotFound();
            }

            return View(lTHCau3);
        }

        // POST: LTHCau3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.LTHCau3 == null)
            {
                return Problem("Entity set 'MvcMovieContext.LTHCau3'  is null.");
            }
            var lTHCau3 = await _context.LTHCau3.FindAsync(id);
            if (lTHCau3 != null)
            {
                _context.LTHCau3.Remove(lTHCau3);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LTHCau3Exists(string id)
        {
          return (_context.LTHCau3?.Any(e => e.Masinhvien == id)).GetValueOrDefault();
        }
    }
}

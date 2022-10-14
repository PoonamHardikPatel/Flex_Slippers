using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Flex_Slippers.Data;
using Flex_Slippers.Models;

namespace Flex_Slippers.Controllers
{
    public class SlippersController : Controller
    {
        private readonly Flex_SlippersContext _context;

        public SlippersController(Flex_SlippersContext context)
        {
            _context = context;
        }

        // GET: Slippers
        /*
        public async Task<IActionResult> Index()
        {
            return View(await _context.Slipper.ToListAsync());
        }
        */

        //-----------------------------------------------------------------------------------

        /*
        public async Task<IActionResult> Index(string searchString)
        {
            var flexslippers = from m in _context.Slipper
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                flexslippers = flexslippers.Where(s => s.Department.Contains(searchString));
            }

            return View(await flexslippers.ToListAsync());
        }
        */

        public async Task<IActionResult> Index(string slipperMaterial, string searchString)
        {
            var flexslippers = from m in _context.Slipper
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                flexslippers = flexslippers.Where(s => s.Department.Contains(searchString));
            }



            // Use LINQ to get list of Material.
            IQueryable<string> MaterialQuery = from m in _context.Slipper
                                               orderby m.Material
                                               select m.Material;

            if (!string.IsNullOrEmpty(slipperMaterial))
            {
                flexslippers = flexslippers.Where(x => x.Material == slipperMaterial);
            }



            var slipperMaterialVM = new SlipperMaterialViewModel
            {
                Materials = new SelectList(await MaterialQuery.Distinct().ToListAsync()),
                Slippers = await flexslippers.ToListAsync()
            };

            return View(slipperMaterialVM);
        }

        //-----------------------------------------------------------------------------------

        // GET: Slippers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slipper = await _context.Slipper
                .FirstOrDefaultAsync(m => m.Id == id);
            if (slipper == null)
            {
                return NotFound();
            }

            return View(slipper);
        }

        // GET: Slippers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Slippers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TypeOfProduct,Department,Price,Size,Width,Material,DescOfProduct,ManufacturingDt")] Slipper slipper)
        {
            if (ModelState.IsValid)
            {
                _context.Add(slipper);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(slipper);
        }

        // GET: Slippers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slipper = await _context.Slipper.FindAsync(id);
            if (slipper == null)
            {
                return NotFound();
            }
            return View(slipper);
        }

        // POST: Slippers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TypeOfProduct,Department,Price,Size,Width,Material,DescOfProduct,ManufacturingDt")] Slipper slipper)
        {
            if (id != slipper.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(slipper);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SlipperExists(slipper.Id))
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
            return View(slipper);
        }

        // GET: Slippers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slipper = await _context.Slipper
                .FirstOrDefaultAsync(m => m.Id == id);
            if (slipper == null)
            {
                return NotFound();
            }

            return View(slipper);
        }

        // POST: Slippers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var slipper = await _context.Slipper.FindAsync(id);
            _context.Slipper.Remove(slipper);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SlipperExists(int id)
        {
            return _context.Slipper.Any(e => e.Id == id);
        }
    }
}

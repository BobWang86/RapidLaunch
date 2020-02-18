using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RapidLaunch.Data;
using RapidLaunch.Models;
using RapidLaunch.Models.Repository;

namespace RapidLaunch.Controllers
{
    public class RocketModelController : Controller
    {
        private readonly RapidLaunchDbContext _context;
        private readonly ILogger _log;

        public RocketModelController(RapidLaunchDbContext context, ILogger<RocketModelController> log)
        {
            _context = context;
            _log = log;
        }

        // GET: RocketModel
        public async Task<IActionResult> Index()
        {
            var rocketModels = _context.RocketModels.Include(r => r.Manufacturer).Include(r => r.RocketCategory).Include(r => r.Rockets).AsNoTracking();
            return View(await rocketModels.ToListAsync());
        }

        // Get: RocketModel/Manage
        public async Task<IActionResult> Manage()
        {
            var rocketModels = _context.RocketModels.Include(r => r.Manufacturer).Include(r => r.RocketCategory).AsNoTracking();
            return View(await rocketModels.ToListAsync());
        }

        // GET: RocketModel/Create
        public IActionResult Create()
        {
            GetRocketModelDropDownList();
            return View();
        }

        // POST: RocketModel/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RocketModelID,Name,Description,Height,Mass,Diameter,PayloadLEO,PayloadGTO,ManufacturerID,RocketCategoryID")] RocketModel rocketModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rocketModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Manage));
            }
            GetRocketModelDropDownList(rocketModel);
            return View(rocketModel);
        }

        // GET: RocketModel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rocketModel = await _context.RocketModels
                .AsNoTracking()
                .FirstOrDefaultAsync(r => r.RocketModelID == id);
            if (rocketModel == null)
            {
                return NotFound();
            }
            GetRocketModelDropDownList(rocketModel);
            return View(rocketModel);
        }

        // POST: RocketModel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RocketModelID,Name,Description,Height,Mass,Diameter,PayloadLEO,PayloadGTO,ManufacturerID,RocketCategoryID")] RocketModel rocketModel)
        {
            if (id != rocketModel.RocketModelID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rocketModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RocketModelExists(rocketModel.RocketModelID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Manage));
            }
            GetRocketModelDropDownList(rocketModel);
            return View(rocketModel);
        }

        // GET: RocketModel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rocketModel = await _context.RocketModels
                .Include(r => r.Manufacturer)
                .Include(r => r.RocketCategory)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.RocketModelID == id);
            if (rocketModel == null)
            {
                return NotFound();
            }

            return View(rocketModel);
        }

        // POST: RocketModel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rocketModel = await _context.RocketModels.FindAsync(id);
            _context.RocketModels.Remove(rocketModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Manage));
        }

        // GET: Rocket/Create
        public IActionResult RocketCreate(int id)
        {
            ViewData["RocketModel"] = _context.RocketModels.FirstOrDefault(i => i.RocketModelID == id);
            ViewData["ExistingRockets"] = _context.Rockets.Where(i => i.RocketModelID == id).Include(r => r.RocketModel).Include(r => r.RocketStatus).ToList();
            ViewData["RocketModelID"] = new SelectList(_context.RocketModels, "RocketModelID", "Name");
            ViewData["RocketStatusID"] = new SelectList(_context.RocketStatuses, "RocketStatusID", "Name");
            return View();
        }

        // POST: Rocket/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RocketCreate([Bind("RocketID,RocketCode,ManufactureDate,ProviderID,RocketModelID,RocketStatusID")] Rocket rocket)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rocket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(RocketCreate));
            }
            ViewData["RocketModelID"] = new SelectList(_context.RocketModels, "RocketModelID", "Name", rocket.RocketModelID);
            ViewData["RocketStatusID"] = new SelectList(_context.RocketStatuses, "RocketStatusID", "Name", rocket.RocketStatusID);
            return View(rocket);
        }

        // GET: Rocket/Edit/5
        public async Task<IActionResult> RocketEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rocket = await _context.Rockets.FindAsync(id);
            if (rocket == null)
            {
                return NotFound();
            }
            ViewData["RocketModelID"] = new SelectList(_context.RocketModels, "RocketModelID", "Name", rocket.RocketModelID);
            ViewData["RocketStatusID"] = new SelectList(_context.RocketStatuses, "RocketStatusID", "Name", rocket.RocketStatusID);
            return View(rocket);
        }

        // POST: Rocket/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RocketEdit(int id, [Bind("RocketID,RocketCode,ManufactureDate,ProviderID,RocketModelID,RocketStatusID")] Rocket rocket)
        {
            if (id != rocket.RocketID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rocket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RocketExists(rocket.RocketID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(RocketCreate), new { id = rocket.RocketModelID });
            }
            ViewData["RocketModelID"] = new SelectList(_context.RocketModels, "RocketModelID", "Name", rocket.RocketModelID);
            ViewData["RocketStatusID"] = new SelectList(_context.RocketStatuses, "RocketStatusID", "Name", rocket.RocketStatusID);
            return View(rocket);
        }

        // GET: Rocket/Delete/5
        public async Task<IActionResult> RocketDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rocket = await _context.Rockets
                .Include(r => r.RocketModel)
                .Include(r => r.RocketStatus)
                .FirstOrDefaultAsync(m => m.RocketID == id);
            if (rocket == null)
            {
                return NotFound();
            }

            return View(rocket);
        }

        // POST: Rocket/Delete/5
        [HttpPost, ActionName("RocketDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RocketDeleteConfirmed(int id)
        {
            var rocket = await _context.Rockets.FindAsync(id);
            _context.Rockets.Remove(rocket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(RocketCreate), new { id = rocket.RocketModelID });
        }

        private void GetRocketModelDropDownList(RocketModel rocketModel = null)
        {
            ViewData["ManufacturerID"] = new SelectList(_context.Manufacturers, "ManufacturerID", "Name", rocketModel?.ManufacturerID);
            ViewData["RocketCategoryID"] = new SelectList(_context.RocketCategories, "RocketCategoryID", "Name", rocketModel?.RocketCategoryID);
        }

        private bool RocketModelExists(int id)
        {
            return _context.RocketModels.Any(e => e.RocketModelID == id);
        }

        private bool RocketExists(int id)
        {
            return _context.Rockets.Any(e => e.RocketID == id);
        }
    }
}

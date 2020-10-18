using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RapidLaunch.Models;
using NetTopologySuite.Geometries;
using Microsoft.Extensions.Logging;
using RapidLaunch.Areas.Identity.Models;

namespace RapidLaunch.Controllers
{
    public class LaunchSiteController : Controller
    {
        private readonly RapidLaunchDbContext _context;
        private readonly ILogger _log;

        public LaunchSiteController(RapidLaunchDbContext context, ILogger<LaunchSiteController> log)
        {
            _context = context;
            _log = log;
        }

        // GET: LaunchSite
        public async Task<IActionResult> Index()
        {
            return View(await _context.LaunchSites.AsNoTracking().ToListAsync());
        }

        // GET: LaunchSite/Manage
        public async Task<IActionResult> Manage()
        {
            return View(await _context.LaunchSites.AsNoTracking().ToListAsync());
        }

        // GET: LaunchSite/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LaunchSite/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LaunchSiteID,Country,Name,BuildDate")] LaunchSite launchSite, double longitude, double latitude)
        {
            if (ModelState.IsValid)
            {
                launchSite.Location = new Point(longitude, latitude) { SRID = 4326 };
                _context.Add(launchSite);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Manage));
            }
            return View(launchSite);
        }

        // GET: LaunchSite/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var launchSite = await _context.LaunchSites.FindAsync(id);
            if (launchSite == null)
            {
                return NotFound();
            }
            return View(launchSite);
        }

        // POST: LaunchSite/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LaunchSiteID,Country,Name,BuildDate")] LaunchSite launchSite, double longitude, double latitude)
        {
            if (id != launchSite.LaunchSiteID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                launchSite.Location = new Point(longitude, latitude) { SRID = 4326 };
                try
                {
                    _context.Update(launchSite);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LaunchSiteExists(launchSite.LaunchSiteID))
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
            return View(launchSite);
        }

        // GET: LaunchSite/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var launchSite = await _context.LaunchSites
                .FirstOrDefaultAsync(m => m.LaunchSiteID == id);
            if (launchSite == null)
            {
                return NotFound();
            }

            return View(launchSite);
        }

        // POST: LaunchSite/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var launchSite = await _context.LaunchSites.FindAsync(id);
            _context.LaunchSites.Remove(launchSite);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Manage));
        }

        // GET: LaunchPad/Create
        public IActionResult PadCreate(int id)
        {
            LaunchSite selectedSite = _context.LaunchSites.FirstOrDefault(s => s.LaunchSiteID == id);
            ViewData["LaunchSite"] = selectedSite;
            ViewData["ExistingLaunchPads"] = _context.LaunchPads.Where(p => p.LaunchSiteID == id).Include(p => p.LaunchSite).ToList();
            ViewData["LaunchSiteID"] = new SelectList(_context.LaunchSites, "LaunchSiteID", "Name", selectedSite.LaunchSiteID);
            return View();
        }

        // POST: LaunchPad/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PadCreate([Bind("LaunchPadID,LaunchPadCode,LaunchSiteID")] LaunchPad launchPad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(launchPad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(PadCreate), new { id = launchPad.LaunchSiteID });
            }
            ViewData["LaunchSiteID"] = new SelectList(_context.LaunchSites, "LaunchSiteID", "Name", launchPad.LaunchSiteID);
            return View(launchPad);
        }

        // GET: LaunchPad/Edit/5
        public async Task<IActionResult> PadEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var launchPad = await _context.LaunchPads.FindAsync(id);
            if (launchPad == null)
            {
                return NotFound();
            }
            ViewData["LaunchSiteID"] = new SelectList(_context.LaunchSites, "LaunchSiteID", "LaunchSiteID", launchPad.LaunchSiteID);
            return View(launchPad);
        }

        // POST: LaunchPad/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PadEdit(int id, [Bind("LaunchPadID,LaunchPadCode,LaunchSiteID")] LaunchPad launchPad)
        {
            if (id != launchPad.LaunchPadID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(launchPad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LaunchPadExists(launchPad.LaunchPadID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(PadCreate), new { id = launchPad.LaunchSiteID });
            }
            ViewData["LaunchSiteID"] = new SelectList(_context.LaunchSites, "LaunchSiteID", "LaunchSiteID", launchPad.LaunchSiteID);
            return View(launchPad);
        }

        // GET: LaunchPad/Delete/5
        public async Task<IActionResult> PadDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var launchPad = await _context.LaunchPads
                .Include(l => l.LaunchSite)
                .FirstOrDefaultAsync(m => m.LaunchPadID == id);
            if (launchPad == null)
            {
                return NotFound();
            }

            return View(launchPad);
        }

        // POST: LaunchPad/Delete/5
        [HttpPost, ActionName("PadDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PadDeleteConfirmed(int id)
        {
            var launchPad = await _context.LaunchPads.FindAsync(id);
            _context.LaunchPads.Remove(launchPad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(PadCreate), new { id = launchPad.LaunchSiteID });
        }

        private bool LaunchSiteExists(int id)
        {
            return _context.LaunchSites.Any(e => e.LaunchSiteID == id);
        }

        private bool LaunchPadExists(int id)
        {
            return _context.LaunchPads.Any(e => e.LaunchPadID == id);
        }
    }
}

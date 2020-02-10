using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RapidLaunch.Data;
using RapidLaunch.Models;

namespace RapidLaunch.Controllers
{
    public class LaunchSiteController : Controller
    {
        private readonly RapidLaunchDbContext _context;

        public LaunchSiteController(RapidLaunchDbContext context)
        {
            _context = context;
        }

        // GET: LaunchSite
        public async Task<IActionResult> Index()
        {
            return View(await _context.LaunchSites.ToListAsync());
        }

        // GET: LaunchSite/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: LaunchSite/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LaunchSite/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LaunchSiteID,Country,Name,Location,BuildDate")] LaunchSite launchSite)
        {
            if (ModelState.IsValid)
            {
                _context.Add(launchSite);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
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
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LaunchSiteID,Country,Name,Location,BuildDate")] LaunchSite launchSite)
        {
            if (id != launchSite.LaunchSiteID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
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
                return RedirectToAction(nameof(Index));
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
            return RedirectToAction(nameof(Index));
        }

        private bool LaunchSiteExists(int id)
        {
            return _context.LaunchSites.Any(e => e.LaunchSiteID == id);
        }
    }
}

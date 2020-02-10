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
    public class LaunchController : Controller
    {
        private readonly RapidLaunchDbContext _context;

        public LaunchController(RapidLaunchDbContext context)
        {
            _context = context;
        }

        // GET: Launch
        public async Task<IActionResult> Index()
        {
            var rapidLaunchDbContext = _context.Launches.Include(l => l.LaunchOrbit).Include(l => l.LaunchPad).Include(l => l.LaunchStatus).Include(l => l.Rocket);
            return View(await rapidLaunchDbContext.ToListAsync());
        }

        // GET: Launch/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var launch = await _context.Launches
                .Include(l => l.LaunchOrbit)
                .Include(l => l.LaunchPad)
                .Include(l => l.LaunchStatus)
                .Include(l => l.Rocket)
                .FirstOrDefaultAsync(m => m.LaunchID == id);
            if (launch == null)
            {
                return NotFound();
            }

            return View(launch);
        }

        // GET: Launch/Create
        public IActionResult Create()
        {
            ViewData["LaunchOrbitID"] = new SelectList(_context.LaunchOrbits, "LaunchOrbitID", "Name");
            ViewData["LaunchPadID"] = new SelectList(_context.LaunchPads, "LaunchPadID", "LaunchPadCode");
            ViewData["LaunchStatusID"] = new SelectList(_context.LaunchStatuses, "LaunchStatusID", "Name");
            ViewData["RocketID"] = new SelectList(_context.Rockets, "RocketID", "RocketID");
            return View();
        }

        // POST: Launch/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LaunchID,LaunchDate,LaunchTime,RocketID,LaunchPadID,LaunchOrbitID,LaunchStatusID")] Launch launch)
        {
            if (ModelState.IsValid)
            {
                _context.Add(launch);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LaunchOrbitID"] = new SelectList(_context.LaunchOrbits, "LaunchOrbitID", "Name", launch.LaunchOrbitID);
            ViewData["LaunchPadID"] = new SelectList(_context.LaunchPads, "LaunchPadID", "LaunchPadCode", launch.LaunchPadID);
            ViewData["LaunchStatusID"] = new SelectList(_context.LaunchStatuses, "LaunchStatusID", "Name", launch.LaunchStatusID);
            ViewData["RocketID"] = new SelectList(_context.Rockets, "RocketID", "RocketID", launch.RocketID);
            return View(launch);
        }

        // GET: Launch/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var launch = await _context.Launches.FindAsync(id);
            if (launch == null)
            {
                return NotFound();
            }
            ViewData["LaunchOrbitID"] = new SelectList(_context.LaunchOrbits, "LaunchOrbitID", "Name", launch.LaunchOrbitID);
            ViewData["LaunchPadID"] = new SelectList(_context.LaunchPads, "LaunchPadID", "LaunchPadCode", launch.LaunchPadID);
            ViewData["LaunchStatusID"] = new SelectList(_context.LaunchStatuses, "LaunchStatusID", "Name", launch.LaunchStatusID);
            ViewData["RocketID"] = new SelectList(_context.Rockets, "RocketID", "RocketID", launch.RocketID);
            return View(launch);
        }

        // POST: Launch/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LaunchID,LaunchDate,LaunchTime,RocketID,LaunchPadID,LaunchOrbitID,LaunchStatusID")] Launch launch)
        {
            if (id != launch.LaunchID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(launch);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LaunchExists(launch.LaunchID))
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
            ViewData["LaunchOrbitID"] = new SelectList(_context.LaunchOrbits, "LaunchOrbitID", "Name", launch.LaunchOrbitID);
            ViewData["LaunchPadID"] = new SelectList(_context.LaunchPads, "LaunchPadID", "LaunchPadCode", launch.LaunchPadID);
            ViewData["LaunchStatusID"] = new SelectList(_context.LaunchStatuses, "LaunchStatusID", "Name", launch.LaunchStatusID);
            ViewData["RocketID"] = new SelectList(_context.Rockets, "RocketID", "RocketID", launch.RocketID);
            return View(launch);
        }

        // GET: Launch/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var launch = await _context.Launches
                .Include(l => l.LaunchOrbit)
                .Include(l => l.LaunchPad)
                .Include(l => l.LaunchStatus)
                .Include(l => l.Rocket)
                .FirstOrDefaultAsync(m => m.LaunchID == id);
            if (launch == null)
            {
                return NotFound();
            }

            return View(launch);
        }

        // POST: Launch/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var launch = await _context.Launches.FindAsync(id);
            _context.Launches.Remove(launch);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LaunchExists(int id)
        {
            return _context.Launches.Any(e => e.LaunchID == id);
        }
    }
}

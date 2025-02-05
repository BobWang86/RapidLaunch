﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RapidLaunch.Areas.Identity.Models;
using RapidLaunch.Models;
using RapidLaunch.Models.ViewModels;

namespace RapidLaunch.Controllers
{
    public class ProviderController : Controller
    {
        private readonly RapidLaunchDbContext _context;
        private readonly ILogger _log;

        public ProviderController(RapidLaunchDbContext context, ILogger<ProviderController> log)
        {
            _context = context;
            _log = log;
        }

        // GET: Provider
        public async Task<IActionResult> Index()
        {
            var viewModel = new ProviderVM();
            viewModel.Providers = await _context.Providers
                .Include(i => i.RocketModelLinks)
                    .ThenInclude(i => i.RocketModel)
                .AsNoTracking()
                .ToListAsync();
            return View(viewModel);
        }

        // GET: Provider/Manage
        public async Task<IActionResult> Manage()
        {
            var viewModel = new ProviderVM();
            viewModel.Providers = await _context.Providers
                .Include(i => i.RocketModelLinks)
                    .ThenInclude(i => i.RocketModel)
                .AsNoTracking()
                .ToListAsync();

            return View(viewModel);
        }

        // GET: Provider/Create
        public IActionResult Create()
        {
            GetRocketModelLinks();
            return View();
        }

        // POST: Provider/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProviderID,Name,Description,EstablishDate")] Provider provider, string[] selectedRocketModels)
        {
            if (selectedRocketModels != null)
            {
                provider.RocketModelLinks = new List<RocketModelLink>();
                foreach (var model in selectedRocketModels)
                {
                    var newLink = new RocketModelLink { ProviderID=provider.ProviderID, RocketModelID=int.Parse(model) };
                    provider.RocketModelLinks.Add(newLink);
                }
            }

            if (ModelState.IsValid)
            {
                _context.Add(provider);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Manage));
            }
            GetRocketModelLinks();
            return View(provider);
        }

        // GET: Provider/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            _log.LogInformation("Loading provider with id {ProviderID}", id);
            if (id == null)
            {
                return NotFound();
            }

            var provider = await _context.Providers
                .Include(i => i.RocketModelLinks).ThenInclude(i => i.RocketModel)
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.ProviderID == id);

            if (provider == null)
            {
                _log.LogError("Could not find provider with id {ProviderID} when attempting to edit", id);
                return NotFound();
            }
            GetRocketModelLinks(id);
            return View(provider);
        }

        // POST: Provider/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, string[] selectedRocketModels)
        {
            if (id == null)
            {
                return NotFound();
            }

            var provider = await _context.Providers
                .Include(i => i.RocketModelLinks).ThenInclude(i => i.RocketModel)
                .FirstOrDefaultAsync(p => p.ProviderID == id);

            if (await TryUpdateModelAsync<Provider>(provider, "", i => i.Name, i => i.Description, i => i.EstablishDate))
            {
                UpdateRocketModelLinks(selectedRocketModels, provider);
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException ex)
                {
                    _log.LogError(ex, "Could not update provider with id {ProviderID}", id);
                }
                return RedirectToAction(nameof(Manage));
            }
            UpdateRocketModelLinks(selectedRocketModels, provider);
            GetRocketModelLinks(id);
            return View(provider);
        }

        // GET: Provider/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            _log.LogInformation("Loading provider with id {ProviderID}", id);
            if (id == null)
            {
                return NotFound();
            }

            var provider = await _context.Providers
                .FirstOrDefaultAsync(m => m.ProviderID == id);
            if (provider == null)
            {
                _log.LogError("Could not find provider with id {ProviderID} when attempting to delete", id);
                return NotFound();
            }
            return View(provider);
        }

        // POST: Provider/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var provider = await _context.Providers.FindAsync(id);
            _context.Providers.Remove(provider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Manage));
        }

        private bool ProviderExists(int id)
        {
            return _context.Providers.Any(e => e.ProviderID == id);
        }

        private void GetRocketModelLinks(int? id=null)
        {
            var allModels = _context.RocketModels;
            var viewModel = new List<RocketModelLinkVM>();
            if (id.HasValue)
            {
                var provider = _context.Providers.Include(i => i.RocketModelLinks).Where(p => p.ProviderID == id).SingleOrDefault();
                var linkedModels = new HashSet<int>(provider.RocketModelLinks.Select(r => r.RocketModelID));
                foreach (var model in allModels)
                {
                    viewModel.Add(new RocketModelLinkVM
                    { 
                        ID = model.RocketModelID,
                        Name = model.Name,
                        Linked = linkedModels.Contains(model.RocketModelID)
                    });
                }
            }
            else
            {
                foreach (var model in allModels)
                {
                    viewModel.Add(new RocketModelLinkVM
                    {
                        ID = model.RocketModelID,
                        Name = model.Name,
                        Linked = false
                    });
                }
            }
            int[] selectedValues = viewModel.Where(i => i.Linked == true).Select(i => i.ID).ToArray();
            ViewBag.LinkedList = new MultiSelectList(viewModel, "ID", "Name", selectedValues);
        }

        private void UpdateRocketModelLinks(string[] selectedRocketModels, Provider provider)
        {
            if (selectedRocketModels == null)
            {
                provider.RocketModelLinks = new List<RocketModelLink>();
                return;
            }

            var selectedRocketModelHS = new HashSet<string>(selectedRocketModels);
            var linkedRocketModelHS = new HashSet<int>(provider.RocketModelLinks.Select(r => r.RocketModelID));
            foreach (var model in _context.RocketModels)
            {
                if (selectedRocketModelHS.Contains(model.RocketModelID.ToString()))
                {
                    if (!linkedRocketModelHS.Contains(model.RocketModelID))
                    {
                        provider.RocketModelLinks.Add(new RocketModelLink { ProviderID = provider.ProviderID, RocketModelID = model.RocketModelID });
                    }
                }
                else
                {
                    if (linkedRocketModelHS.Contains(model.RocketModelID))
                    {
                        RocketModelLink linkToRemove = provider.RocketModelLinks.FirstOrDefault(i => i.RocketModelID == model.RocketModelID);
                        _context.Remove(linkToRemove);
                    }
                }
            }

        }
    }
}

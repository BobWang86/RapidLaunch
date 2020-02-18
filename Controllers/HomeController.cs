using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RapidLaunch.Data;
using RapidLaunch.Models;
using RapidLaunch.Models.ViewModels;
using RapidLaunch.Models.Repository;
using Microsoft.Extensions.Logging;

namespace RapidLaunch.Controllers
{
    public class HomeController : Controller
    {
        private readonly RapidLaunchDbContext _context;
        private readonly ILogger _log;
        private static readonly HttpClient _client = new HttpClient();
        
        public HomeController(RapidLaunchDbContext context,
            ILogger<HomeController> log)
        {
            _context = context;
            _log = log;
        }

        public HomeController(RapidLaunchDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Call Rocket Launch API To Get The Next Five Rocket Launches To Be Presented On The Dashboard
            using (var response = _client.GetAsync("https://fdo.rocketlaunch.live/json/launches/next/5"))
            {
                var responseContent = await response.Result.Content.ReadAsStringAsync();
                var deserializedResponse = JsonConvert.DeserializeObject(responseContent);
                ViewData["ResponseString"] = responseContent;
                ViewData["ResponseObject"] = deserializedResponse;
                _log.LogInformation("Rocket Launch API call with status code {StatusCode}", response.Result.StatusCode);
            }

            return View();
        }

        public async Task<JsonResult> GetLaunchHistory()
        {
            // Retrieve Data From Database View LaunchHistoryByYear And Return In Json Format
            IEnumerable<LaunchHistory> histories = await _context.LaunchHistories.OrderBy(l => l.LaunchYear).AsNoTracking().ToListAsync();

            return Json(histories);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

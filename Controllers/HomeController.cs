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

namespace RapidLaunch.Controllers
{
    public class HomeController : Controller
    {
        private readonly RapidLaunchDbContext _context;
        private static readonly HttpClient _client = new HttpClient();

        public HomeController(RapidLaunchDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            using (var response = _client.GetAsync("https://fdo.rocketlaunch.live/json/launches/next/5"))
            {
                var responseContent = await response.Result.Content.ReadAsStringAsync();
                var deserializedResponse = JsonConvert.DeserializeObject(responseContent);
                ViewData["ResponseString"] = responseContent;
                ViewData["ResponseObject"] = deserializedResponse;
            }

            return View();
        }

        public async Task<JsonResult> GetLaunchHistory()
        {
            IEnumerable<LaunchHistory> histories = await _context.LaunchHistories.ToListAsync();

            return Json(histories);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

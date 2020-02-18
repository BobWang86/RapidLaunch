using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Components
{
    public class NavBarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.CurrentPage = RouteData?.Values;
            return View("/Views/Shared/_NavBar.cshtml");
        }
    }
}

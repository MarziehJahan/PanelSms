using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Panel.DAL;
using PanelSms.Models;

namespace PanelSms.Controllers
{
    public class HomeController : Controller
    {
        
        PanelSimorghContext ctx;
        PanelSimorghViewModel simorghViewModel;
        public HomeController()
        {
            ctx = new PanelSimorghContext();
            simorghViewModel = new PanelSimorghViewModel()
            {
                AcquaintanceTypes = ctx.Acquaintances.Select(a => new SelectListItem()
                {
                    Text = a.AcquaintanceDesc,
                    Value = a.AcquaintanceDesc,
                    Selected=true
                }),
                Conditions = ctx.Conditions,
                UserPanels = ctx.users.Select(a => new SelectListItem()
                {
                    Text = a.UserPanelDescription,
                    Value = a.UserPanelDescription
                })
            };
        }
        public IActionResult Index()
        {
            return View(simorghViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(PanelSimorghViewModel model)
        {
            return View(simorghViewModel);
        }
    }
}

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
                    Value = a.AcquaintanceId.ToString(),
                    Selected=true
                }),
                Conditions = ctx.Conditions,
                UserPanels = ctx.users.Select(a => new SelectListItem()
                {
                    Text = a.UserPanelDescription,
                    Value = a.UserPanelId.ToString()
                }),
                PhoneNumber=null,
                PostalCode=null,
                BirthNo=null,
                NationalCode=null
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
            if (ModelState.IsValid)
            {
                ctx.Panels.Add(new PanelSimorgh()
                {
                    acquaintanceType = new Acquaintance() { AcquaintanceId = Convert.ToInt32(model.AcquaintanceId) },
                    Address = model.Address,
                    BirthNo = Convert.ToInt32(model.BirthNo),
                    Name = model.Name,
                    FName = model.FName,
                    Email = model.Email,
                    NationalCode = Convert.ToInt32(model.NationalCode),
                    PhoneCall = Convert.ToInt32(model.PhoneCall),
                    PhoneNumber = Convert.ToInt32(model.PhoneNumber),
                    Con = new Condition() { ConditionId = model.ConditionId },
                    PostalCode = Convert.ToInt32(model.PostalCode),
                    terms = new TermsAcceptance() { TermsAcceptanceId = 1 },
                    Username = model.Username,
                    userpanel = new UserPanel() { UserPanelId = Convert.ToInt32(model.UserPanelId) }
                });
               // ctx.SaveChanges();
            }
            return View(simorghViewModel);
        }
    }
}

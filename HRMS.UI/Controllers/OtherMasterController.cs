﻿using Microsoft.AspNetCore.Mvc;

namespace HRMS.UI.Controllers
{
    public class OtherMasterController : Controller
    {
        public IActionResult OrganizationPolicy()
        {
            return View();
        }

        public IActionResult GeoLocationMasterAssign()
        {
            return View();
        }

        public IActionResult TicketType()
        {
            return View();
        }
    }
}

﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    public class DestinationMediatRController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}

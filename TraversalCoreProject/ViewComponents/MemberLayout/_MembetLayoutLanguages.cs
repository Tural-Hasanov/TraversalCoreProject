﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.ViewComponents.MemberLayout
{
    public class _MembetLayoutLanguages:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

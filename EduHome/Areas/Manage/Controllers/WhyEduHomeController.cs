﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Manage.Controllers
{
    public class WhyEduHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FrontFinalAspCore.Controllers
{
    public class ButtonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
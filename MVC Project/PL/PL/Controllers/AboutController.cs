﻿using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

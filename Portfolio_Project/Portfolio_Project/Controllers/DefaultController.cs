﻿using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

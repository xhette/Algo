﻿using Microsoft.AspNetCore.Mvc;

namespace Algo.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

﻿using Microsoft.AspNetCore.Mvc;

namespace DHBooks.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

//Returns Collection view
namespace shortbox.Controllers
{
    public class CollectionController : Controller
    {
        // GET: /Collection/
        public IActionResult Index()
        {
            return View();
        }

    }
}

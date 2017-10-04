﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CognitiveLocator.WebAPI.Controllers
{
    public class HomeController : Controller
    {
        [System.Web.Mvc.RequireHttps]
        public ActionResult Index()
        {
            ViewBag.Title = "Our API is running!! :)";
            return View();
        }
    }
}
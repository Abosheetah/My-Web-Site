﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace My_Web_Site.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My Name is Muhammad Abosheetah, i'm a programmer.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My Name is Muhammad Abosheetah, i'm a programmer.";

            return View();
        }
    }
}
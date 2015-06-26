﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SharpMedia.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "SharpMedia is a media library catalog.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Get in touch with me.";

            return View();
        }
    }
}
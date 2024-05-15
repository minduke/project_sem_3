﻿using GiveAID.Models.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiveAID.Controllers
{
    public class HomeController : BaseController
    {
        GiveAIDEntities en = new GiveAIDEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CardDetails()
        {
            return View();
        }
        
    }
}
﻿using MVC_Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new ApplicationDbContext();
            var post = db.Posts.OrderByDescending(p => p.Date).Take(3);
            return View(post.ToList());
        }


        public ActionResult About()
        {
            ViewBag.message = "asdasd";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.message = "asdasd";
            return View();
        }

    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Login()
        {
            var arbin = new User() { FirstName = "arbin", LastName = "shrestha", Password = "arbinpass" };
            
            return View(arbin);
        }

        public ViewResult Register()
        {
            return View();
        }
    }
}
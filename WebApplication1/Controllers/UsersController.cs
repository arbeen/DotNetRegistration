using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using myApp.models;
using myDb.Db.DbOperations;

namespace WebApplication1.Controllers
{
    public class UsersController : Controller
    {
        UsersRepository repository = null;

        public UsersController()
        {
            repository = new UsersRepository();
        }

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

        [HttpPost]
        public ViewResult Register(UsersModel model)
        {
            if (ModelState.IsValid)
            {
                int id = repository.AddUser(model);
                if (id > 0)
                {
                    ModelState.Clear();
                    ViewBag.IsSuccess = "Data Added";
                }
            }
            return View();
        }
    }
}
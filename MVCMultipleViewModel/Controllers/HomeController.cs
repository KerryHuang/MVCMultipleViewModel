using MVCMultipleViewModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMultipleViewModel.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login([Bind(Prefix = "login")]LoginViewModels model)
        {
            return View(model);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register([Bind(Prefix = "register")]RegisterViewModels model)
        {
            return View(model);
        }

        public ActionResult Combine()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Combine(GroupViewModels model)
        {
            return View(model);
        }
    }
}
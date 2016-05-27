using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Ledger.Models;
using System.Security.Claims;

namespace Ledger.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            if (User.IsSignedIn())
            {
                return View();
            }
            else
            {
                return View("../User/Login");
            }
        }

        public ViewResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public ViewResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public ViewResult Error()
        {
            return View();
        }
    }
}

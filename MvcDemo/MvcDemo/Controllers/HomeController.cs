using MvcDemo.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index(int t)
        {

            
            ViewBag.Countries=new List<string>()
            {
                 "India",
                 "US",
                 "UK",
                "Canada",
                SessionManager.GetInstance.sMessage
            };
            return View();
        }

    }
}
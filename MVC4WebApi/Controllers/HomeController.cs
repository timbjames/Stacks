using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC4WebApi.Models;

namespace MVC4WebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MVISEntities db = new MVISEntities();            
            return View();
        }
    }
}

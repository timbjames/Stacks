using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Raven.Client;

namespace Mvc4App.Controllers
{
    
    public class RavenDBController : Controller
    {

        private IDocumentSession _session;
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _session = Mvc4App.MvcApplication.documentStore.OpenSession();    
        }
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.IsChildAction) return;
            using (_session)
            {
                if (filterContext.Exception != null) return;
                if (_session != null) _session.SaveChanges();                
            }
        }
               
        public ActionResult Index()
        {
            //var prod = _session.Load<Model.Product>(1);
            //return View(prod);
            var sheep = new Sheep
            {
                Name = "Tim the Sheep",
                Surname = "James"
            };
            _session.Store(sheep);
            _session.SaveChanges();

            return View();
        }

        public ActionResult CreateProduct()
        {
            return Content("test");
        }

    }

    public class Sheep
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    public class Octopus
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}

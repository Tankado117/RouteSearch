?using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using routeSearch.Models;

namespace routeSearch.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult result()
        {
          model Model = new model();
          Model.origin = originHtml;
          Model.destination = destinationHtml;

          ViewData["origin"] = Model.origin;
          ViewData["destination"] = Model.destination;

          return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



using Clase9.Models;namespace Clase9.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];

            var message = String.Format("{0} {1} {2}", controller, action, id);

            ViewBag.Message = message;


            return View();
        }

        public ActionResult About()
        {
            //instanciar el modelo nuevo de AboutModel
            var model = new AboutModel();

            //Asigno valores a las propiedades del Modelo
            model.Nombre = "Mónica";
            model.Ubicacion = "Asunción";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

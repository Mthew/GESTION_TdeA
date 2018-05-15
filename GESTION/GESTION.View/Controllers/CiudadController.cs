using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using GESTION.Rules;

namespace GESTION.View.Controllers
{
    public class CiudadController : Controller
    {
        // GET: Ciudad
        public ActionResult Index()
        {
            CiudadRules objCiudad = new CiudadRules();
            return View(objCiudad.GetAll());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using GESTION.Rules;
using GESTION.View.Models;
using System.Web.Security;

namespace GESTION.View.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string userName, string password)
        {
            try
            {
                var usuario = new AuthenticationRules().Login(userName, password);
                if (usuario != null)
                {
                    Utilities.SetCurrentUser(usuario);
                    FormsAuthentication.SetAuthCookie(userName, false);
                    return RedirectToAction("Index", "Ciudad");
                }
                else
                {
                    throw new Exception("Usuario y contraseña no validos");
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
            }
            return View("Index");
        }
    }
}
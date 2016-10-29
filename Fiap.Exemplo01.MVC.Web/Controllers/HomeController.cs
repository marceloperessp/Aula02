using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo01.MVC.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //Método para encontrar a página index; O caminho dela é Home/Index que vem do primeiro nome da classe de Controller e o método
        public ActionResult Index()
        {
            return View();
        }
    }
}
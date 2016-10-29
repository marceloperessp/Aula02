using Fiap.Exemplo01.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo01.MVC.Web.Controllers
{
    public class ClienteController : Controller
    {

        private static List<Cliente> _lista = new List<Cliente>();

        // GET: Cliente
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Cliente cliente)
        {
            _lista.Add(cliente);
            TempData["msg"] = "Cadastrado com sucesso";

            return RedirectToAction("Cadastrar");
        }

        public ActionResult Listar()
        {
            //ViewBag.lista = _lista;
            return View(_lista);
        }

    }
}
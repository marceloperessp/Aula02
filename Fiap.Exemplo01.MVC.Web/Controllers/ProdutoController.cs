using Fiap.Exemplo01.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo01.MVC.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private static List<Produto> _lista = new List<Produto>();
        // GET: Produto
       //Terá duas ações, uma resposta para cadastrar a página e uma requisição realizar o cadastro  
       
            //Método get para exibir a página 
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        //ATALHO: mvcaction4
        [HttpPost]
        public ActionResult Cadastrar(Produto produto)
        {
            //adiciona produto na lista(simulando o DB)
            _lista.Add(produto);
            //ViewBag envia para a página html o objeto que queremos, assim como o TempData
            ViewBag.prod = produto;
            TempData["mensagem"] = "Produto cadastrado!";
            //retorna a view Sucesso.cshtml 
            //return View("Sucesso",produto);
            //return Content(produto.Nome + " " + produto.Quantidade + " " + produto.Valor);
            return RedirectToAction("Cadastrar");
        }


        public ActionResult Sucesso()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Listar()
        {
            return View(_lista);
        }
    }
}
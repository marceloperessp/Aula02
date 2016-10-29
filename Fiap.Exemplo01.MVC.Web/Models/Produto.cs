using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo01.MVC.Web.Models
{
    public class Produto
    {

        private string _nome;
        private int _quantidade;
        private decimal _valor;

        public Produto(string nome, int quantidade, decimal valor)
        {
            _nome = nome;
            _quantidade = quantidade;
            _valor = valor;
        }

        public Produto()
        {

        }

        public string Nome { get; set; }

        public int Quantidade { get; set; }

        public decimal Valor { get; set; }

    }
}
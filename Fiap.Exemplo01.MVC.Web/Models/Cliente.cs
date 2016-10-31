﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo01.MVC.Web.Models
{
    public class Cliente
    {

        public string nome { get; set; }

        public int idade { get; set; }

        public decimal credito{ get; set; }

        [Display(Name = "Possui necessidades especiais?")]
        public bool NecessidadesEspeciais { get; set;}

        [Display(Name = "Data de Nascimento")]
        [UIHint("Date")]
        public DateTime Nascimento { get; set; }

        [Display(Name = "Estado Civil" )]
        public string EstadoCivil { get; set; }
        
    }

}
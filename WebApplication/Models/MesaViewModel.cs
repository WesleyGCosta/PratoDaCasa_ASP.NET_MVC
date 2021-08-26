using Dominio.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class MesaViewModel
    {
        [HiddenInput]
        public Guid Id { get; set; }
        public int Numero { get; set; }
        public int QntCadeira {  get; set; }
        public EStatus Status { get; set; }
        public int QntCliente { get; set; }
    }
}

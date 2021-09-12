using Dominio.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class MesaViewModel
    {
        public MesaViewModel()
        {
            Data = DateTime.Now;
            Cliente = "Consumidor";
        }

        [HiddenInput]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório!!!")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório!!!")]
        public string Cliente { get; set; }

        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório!!!")]
        public EStatusMesa Status { get; set; }

    }
}

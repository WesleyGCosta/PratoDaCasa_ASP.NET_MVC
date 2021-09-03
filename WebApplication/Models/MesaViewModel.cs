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
            Id = Guid.NewGuid();
        }

        [HiddenInput]
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "*Campo Obrigatório!!!")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório!!!")]
        public int QntCadeira {  get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório!!!")]
        public EStatus Status { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório!!!")]
        public int QntCliente { get; set; }
    }
}

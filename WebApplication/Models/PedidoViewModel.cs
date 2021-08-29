using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class PedidoViewModel
    {
        public Guid Id {  get; set; }
        public DateTime Data { get; set; }
        public decimal ValorTotal { get; set; }
        public int Quantidade { get; set; }
    }
}

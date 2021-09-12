using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class PedidoViewModel
    {
        public Guid Id {  get; set; }
        public DateTime DatadoPedido { get; set; }
        public decimal ValorTotal { get; set; }
        public EStatusPedido StatusPedido { get; set; }
        public int QuantidadeDeItens { get; set; }
    }
}

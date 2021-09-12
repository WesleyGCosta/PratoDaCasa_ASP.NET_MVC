using Dominio.Enums;
using System;

namespace WebApplication.Models
{
    public class ItemDoPedidoViewModel
    {
        public Guid Id { get; set; }
        public int Quantidade { get; set;  }
        public decimal ValorUnitario { get; set; }
        public decimal SubTotal { get; set; }
        public EStatusItem StatusItem { get; set; }
    }
}

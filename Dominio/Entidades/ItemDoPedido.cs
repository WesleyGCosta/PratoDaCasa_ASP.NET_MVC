using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class ItemDoPedido
    {
        public ItemDoPedido(int quantidade, decimal valorUnitario, decimal subTotal, EStatusItem statusItem)
        {
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
            SubTotal = subTotal;
            StatusItem = statusItem;
        }

        public Guid Id { get; private set; }
        public Guid PedidoId { get; private set; }
        public Guid ProdutoId { get; private set; }
        public int Quantidade { get; private set; }
        public decimal ValorUnitario { get; private set; }
        public decimal SubTotal { get; private set; }
        public EStatusItem StatusItem { get; private set; }

        public virtual Pedido Pedido { get; private set; }
        public virtual Produto Produto {  get; private set; }
        
    }
}

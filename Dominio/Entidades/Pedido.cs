using Dominio.Enums;
using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Pedido
    {
        public Pedido(DateTime datadoPedido, decimal valorTotal, EStatusPedido statusPedido, int quantidadeDeItens)
        {
            DatadoPedido = datadoPedido;
            ValorTotal = valorTotal;
            StatusPedido = statusPedido;
            QuantidadeDeItens = quantidadeDeItens;
            ItemDoPedido = new List<ItemDoPedido>();
        }

        public Guid Id {  get; private set; }
        public Guid MesaId {  get; private set; }
        public DateTime DatadoPedido { get; private set; }
        public decimal ValorTotal { get; private set; }
        public EStatusPedido StatusPedido {  get; private set; }
        public int QuantidadeDeItens {  get; private set; }

        public Mesa Mesa {  get; private set; }
        public virtual ICollection<ItemDoPedido> ItemDoPedido { get; private set; }

    }
}

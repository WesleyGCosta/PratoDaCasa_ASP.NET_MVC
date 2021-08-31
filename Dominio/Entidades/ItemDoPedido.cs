using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class ItemDoPedido
    {
        public Guid Id { get; private set; }
        public int Quantidade { get; private set; }
        public decimal Preco { get; private set; }
        public virtual ICollection<Pedido> Pedidos { get; private set; }
        public virtual ICollection<Produto> Produto {  get; private set; }
        
    }
}

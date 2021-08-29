using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Pedido
    {
        public Guid Id {  get; private set; }
        public Guid ClienteId {  get; private set; }
        public Guid ProdutoId {  get; private set; }
        public DateTime Data { get; set; }
        public decimal ValorTotal { get; set; }
        public int Quantidade {  get; private set; }

        public Cliente Cliente {  get; private set; }
        public Produto Produto { get; private set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Pedido
    {
        public Guid Id {  get; private set; }
        public Guid ClienteId {  get; private set; }
        public Guid MesaId {  get; private set; }
        public Guid ProdutoId {  get; private set; }
        public int Quantidade {  get; private set; }

        public Cliente Cliente {  get; private set; }
        public ICollection<Produto> Produtos {  get; private set;}

    }
}

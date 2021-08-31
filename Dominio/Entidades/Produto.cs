using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Produto
    {
        public Guid Id { get; private set;  }
        public Guid TipoDeProdutoId { get; private set;  }
        public Guid ItemDoPedidoId { get; private set;  }
        public string Nome {  get; private set; }
        public decimal Valor { get; private set;  }
        public int QuantidadeEstoque {  get; private set; }

        public TipoDeProduto TipoDeProduto {  get; private set; }
        public ItemDoPedido ItemDoPedido {  get; private set; }


    }
}

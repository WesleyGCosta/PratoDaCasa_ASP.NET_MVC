using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Produto
    {
        public Produto(
            string descricao, 
            decimal precoCompra, 
            decimal precoVenda, 
            int qtdeEstoque, 
            DateTime dataCadastro, 
            EStatusProduto estatusProduto)
        {
            Descricao = descricao;
            PrecoCompra = precoCompra;
            PrecoVenda = precoVenda;
            QtdeEstoque = qtdeEstoque;
            DataCadastro = dataCadastro;
            EstatusProduto = estatusProduto;
            ItemDoPedido = new List<ItemDoPedido>();
        }

        public Guid Id { get; private set;  }
        public Guid TipoDeProdutoId { get; private set;  }
        public Guid ItemDoPedidoId { get; private set;  }
        public string Descricao { get; private set; }
        public decimal PrecoCompra { get; private set; }
        public decimal PrecoVenda { get; private set; }
        public int QtdeEstoque { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public EStatusProduto EstatusProduto { get; private set; }

        public virtual ICollection<ItemDoPedido> ItemDoPedido {  get; private set; }
    }
}

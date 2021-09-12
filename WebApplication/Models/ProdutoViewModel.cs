using Dominio.Enums;
using System;

namespace WebApplication.Models
{
    public class ProdutoViewModel
    {
        public Guid Id {  get; set; }
        public string Descricao { get; set; }
        public decimal PrecoCompra { get; set; }
        public decimal PrecoVenda { get; set; }
        public int QtdeEstoque { get; set; }
        public DateTime DataCadastro { get; set; }
        public EStatusProduto EstatusProduto { get; set; }
    }
}

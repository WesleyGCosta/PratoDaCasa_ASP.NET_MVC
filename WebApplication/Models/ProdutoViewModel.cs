using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class ProdutoViewModel
    {
        public Guid Id {  get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class TipoDeProduto
    {
        public Guid Id { get; private set; }
        public string Descricao { get; private set;  }

        public ICollection<Produto> Produtos {  get; private set;}
    }
}

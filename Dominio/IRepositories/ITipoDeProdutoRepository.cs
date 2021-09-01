using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.IRepositories
{
    public interface ITipoDeProdutoRepository
    {
        Task Adicionar(TipoDeProduto tipoDeProduto);
        Task Alterar(TipoDeProduto tipoDeProduto);
        Task Deletar(TipoDeProduto tipoDeProduto);
        Task<TipoDeProduto> BuscarPoId(Guid id);
        Task<IEnumerable<TipoDeProduto>> BuscarTodos();
    }
}

using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.IRepositories
{
    public interface IProdutoRepository
    {
        Task Adicionar(Produto produto);
        Task Detalhar(Produto produto);
        Task Deletar(Produto produto);
        Task<Produto> BuscarPoId(Guid id);
        Task<IEnumerable<Produto>> BuscarTodos();
    }
}

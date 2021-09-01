using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.IRepositories
{
    public interface IClienteRepository
    {
        Task Adicionar(Cliente cliente);
        Task Alterar(Cliente cliente);
        Task Deletar(Cliente cliente);
        Task<Cliente> BuscarPoId(Guid id);
        Task<IEnumerable<Cliente>> BuscarTodos();
    }
}

using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.IRepositories
{
    public interface IMesaRepository
    {
        Task Adicionar(Mesa mesa);
        Task Alterar(Mesa mesa);
        Task Deletar(Mesa mesa);
        Task<Mesa> BuscarPoId(Guid id);
        Task<IEnumerable<Mesa>> BuscarTodos();
    }
}

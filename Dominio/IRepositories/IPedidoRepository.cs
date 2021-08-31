using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.IRepositories
{
    public interface IPedidoRepository
    {
        Task Adicionar(Pedido pedido);
        Task Detalhar(Pedido pedido);
        Task Deletar(Pedido pedido);
        Task<Pedido> BuscarPoId(Guid id);
        Task<IEnumerable<Pedido>> BuscarTodos();
    }
}

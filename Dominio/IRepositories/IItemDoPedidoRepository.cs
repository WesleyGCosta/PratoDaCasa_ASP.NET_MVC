using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.IRepositories
{
    public interface IItemDoPedidoRepository
    {
        Task Adicionar(ItemDoPedido itemDoPedido);
        Task Alterar(ItemDoPedido itemDoPedido);
        Task Deletar(ItemDoPedido itemDoPedido);
        Task<ItemDoPedido> BuscarPoId(Guid id);
        Task<IEnumerable<ItemDoPedido>> BuscarTodos();
    }
}

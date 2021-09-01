using Dominio.Entidades;
using Dominio.IRepositories;
using Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Persistencia
{
    public class ItemDoPedidoRepository : IItemDoPedidoRepository
    {
        private readonly DataContext _dataContext;
        public ItemDoPedidoRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Adicionar(ItemDoPedido itemDoPedido)
        {
            _dataContext.ItemDoPedidos.Add(itemDoPedido);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Alterar(ItemDoPedido itemDoPedido)
        {
            _dataContext.Update(itemDoPedido);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Deletar(ItemDoPedido itemDoPedido)
        {
            _dataContext.Remove(itemDoPedido);
            await _dataContext.SaveChangesAsync();
        }
        public async Task<ItemDoPedido> BuscarPoId(Guid id)
        {
            var itensDoPedido = await _dataContext.ItemDoPedidos.FirstOrDefaultAsync(i => i.Id == id);
            return itensDoPedido;
        }
        public async Task<IEnumerable<ItemDoPedido>> BuscarTodos()
        {
            return await _dataContext.ItemDoPedidos.AsNoTracking().ToListAsync();
        }
    }
}

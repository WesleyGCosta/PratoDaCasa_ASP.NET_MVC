using Dominio.Entidades;
using Dominio.IRepositories;
using Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Persistencia
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly DataContext _dataContext;
        public PedidoRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Adicionar(Pedido pedido)
        {
            _dataContext.Pedidos.Add(pedido);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Alterar(Pedido pedido)
        {
            _dataContext.Update(pedido);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Deletar(Pedido pedido)
        {
            _dataContext.Remove(pedido);
            await _dataContext.SaveChangesAsync();
        }
        public async Task<Pedido> BuscarPoId(Guid id)
        {
            var pedidos = await _dataContext.Pedidos.FirstOrDefaultAsync(p => p.Id == id);
            return pedidos;
        }
        public async Task<IEnumerable<Pedido>> BuscarTodos()
        {
            return await _dataContext.Pedidos.AsNoTracking().ToListAsync();
        }
    }
}

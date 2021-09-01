using Dominio.Entidades;
using Dominio.IRepositories;
using Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Persistencia
{
    public class MesaRepository : IMesaRepository
    {
        private readonly DataContext _dataContext;
        public MesaRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Adicionar(Mesa mesa)
        {
            _dataContext.Mesas.Add(mesa);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Alterar(Mesa mesa)
        {
            _dataContext.Update(mesa);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Deletar(Mesa mesa)
        {
            _dataContext.Remove(mesa);
            await _dataContext.SaveChangesAsync();
        }
        public async Task<Mesa> BuscarPoId(Guid id)
        {
            var mesa = await _dataContext.Mesas.FirstOrDefaultAsync(m => m.Id == id);
            return mesa;
        }
        public async Task<IEnumerable<Mesa>> BuscarTodos()
        {
            return await _dataContext.Mesas.AsNoTracking().ToListAsync();
        }
    }
}

using Dominio.Entidades;
using Dominio.IRepositories;
using Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Persistencia
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataContext _dataContext;
        public ClienteRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Adicionar(Cliente cliente)
        {
            _dataContext.Clientes.Add(cliente);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Alterar(Cliente cliente)
        {
            _dataContext.Update(cliente);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Deletar(Cliente cliente)
        {
            _dataContext.Remove(cliente);
            await _dataContext.SaveChangesAsync();
        }
        public async Task<Cliente> BuscarPoId(Guid id)
        {
            var clientes = await _dataContext.Clientes.FirstOrDefaultAsync(c => c.Id == id);
            return clientes;
        }
        public async Task<IEnumerable<Cliente>> BuscarTodos()
        {
            return await _dataContext.Clientes.AsNoTracking().ToListAsync();
        }
    }
}

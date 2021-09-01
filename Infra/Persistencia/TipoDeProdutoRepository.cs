using Dominio.Entidades;
using Dominio.IRepositories;
using Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Persistencia
{
    public class TipoDeProdutoRepository : ITipoDeProdutoRepository
    {
        private readonly DataContext _dataContext;
        public TipoDeProdutoRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Adicionar(TipoDeProduto tipoDeProduto)
        {
            _dataContext.TipoDeProdutos.Add(tipoDeProduto);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Alterar(TipoDeProduto tipoDeProduto)
        {
            _dataContext.Update(tipoDeProduto);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Deletar(TipoDeProduto tipoDeProduto)
        {
            _dataContext.Remove(tipoDeProduto);
            await _dataContext.SaveChangesAsync();
        }
        public async Task<TipoDeProduto> BuscarPoId(Guid id)
        {
            var tiposDeProdutos = await _dataContext.TipoDeProdutos.FirstOrDefaultAsync(t => t.Id == id);
            return tiposDeProdutos;
        }
        public async Task<IEnumerable<TipoDeProduto>> BuscarTodos()
        {
            return await _dataContext.TipoDeProdutos.AsNoTracking().ToListAsync();
        }
    }
}

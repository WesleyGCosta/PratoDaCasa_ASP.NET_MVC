using Dominio.Entidades;
using Dominio.IRepositories;
using Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Persistencia
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly DataContext _dataContext;
        public ProdutoRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Adicionar(Produto produto)
        {
            _dataContext.Produtos.Add(produto);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Alterar(Produto produto)
        {
            _dataContext.Update(produto);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Deletar(Produto produto)
        {
            _dataContext.Remove(produto);
            await _dataContext.SaveChangesAsync();
        }
        public async Task<Produto> BuscarPoId(Guid id)
        {
            var produtos = await _dataContext.Produtos.FirstOrDefaultAsync(p => p.Id == id);
            return produtos;
        }
        public async Task<IEnumerable<Produto>> BuscarTodos()
        {
            return await _dataContext.Produtos.AsNoTracking().ToListAsync();
        }
    }
}

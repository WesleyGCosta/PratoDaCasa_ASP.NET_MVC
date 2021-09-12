using Dominio.Entidades;
using Infra.Contexto.Maps;
using Microsoft.EntityFrameworkCore;

namespace Infra.Contexto
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemDoPedido> ItemDoPedidos {  get; set; }
        public DbSet<Produto> Produtos {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MesaMap());
            modelBuilder.ApplyConfiguration(new PedidoMap());
            modelBuilder.ApplyConfiguration(new ItemDoPedidoMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
        }

    }
}

using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Contexto.Maps
{
    public class TipoDeProdutoMap : IEntityTypeConfiguration<TipoDeProduto>
    {
        public void Configure(EntityTypeBuilder<TipoDeProduto> builder)
        {
            builder.ToTable("TiposDeProdutos");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Descricao).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");

            builder.HasMany(p => p.Produtos).WithOne(t => t.TipoDeProduto).HasForeignKey(t => t.TipoDeProdutoId);
        }
    }
}

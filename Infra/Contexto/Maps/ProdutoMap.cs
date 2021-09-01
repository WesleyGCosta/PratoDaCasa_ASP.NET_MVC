using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Contexto.Maps
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produtos");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).IsRequired().HasMaxLength(30).HasColumnType("varchar(30)");
            builder.Property(p => p.Valor).IsRequired().HasColumnType("decimal");
            builder.Property(p => p.QuantidadeEstoque).IsRequired().HasColumnType("int");
        }
    }
}

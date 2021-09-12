using Dominio.Entidades;
using Dominio.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infra.Contexto.Maps
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produtos");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Descricao).IsRequired().HasMaxLength(30).HasColumnType("varchar(30)");
            builder.Property(p => p.PrecoCompra).IsRequired().HasColumnType("decimal");
            builder.Property(p => p.PrecoVenda).IsRequired().HasColumnType("decimal");
            builder.Property(p => p.QtdeEstoque).IsRequired().HasColumnType("int");
            builder.Property(p => p.DataCadastro).IsRequired().HasColumnType("date");
            builder.Property(p => p.EstatusProduto).HasConversion(y => y.ToString(), y => (EStatusProduto)Enum.Parse(typeof(EStatusProduto), y)).HasMaxLength(15).IsRequired();

            builder.HasMany(p => p.ItemDoPedido).WithOne(p => p.Produto).HasForeignKey(p => p.PedidoId);
        }
    }
}

using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Contexto.Maps
{
    public class ItemDoPedidoMap : IEntityTypeConfiguration<ItemDoPedido>
    {
        public void Configure(EntityTypeBuilder<ItemDoPedido> builder)
        {
            builder.ToTable("ItensDoPedido");
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Quantidade).IsRequired().HasColumnType("int");
            builder.Property(i => i.Preco).IsRequired().HasColumnType("decimal");

            builder.HasMany(p => p.Pedidos).WithOne(i => i.ItemDoPedido).HasForeignKey(i => i.ItemDoPedidoId);
            builder.HasMany(c => c.Produto).WithOne(i => i.ItemDoPedido).HasForeignKey(i => i.ItemDoPedidoId);

        }
    }
}

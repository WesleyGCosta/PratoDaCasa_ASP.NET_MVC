using Dominio.Entidades;
using Dominio.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Contexto.Maps
{
    public class PedidoMap : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedidos");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.DatadoPedido).IsRequired().HasColumnType("date");
            builder.Property(p => p.ValorTotal).IsRequired().HasColumnType("decimal");
            builder.Property(p => p.StatusPedido).HasConversion(y => y.ToString(), y => (EStatusPedido)Enum.Parse(typeof(EStatusPedido), y)).HasMaxLength(15).IsRequired();
            builder.Property(p => p.QuantidadeDeItens).IsRequired().HasColumnType("int");

            builder.HasMany(p => p.ItemDoPedido).WithOne(p => p.Pedido).HasForeignKey(p => p.PedidoId);
        }
    }
}

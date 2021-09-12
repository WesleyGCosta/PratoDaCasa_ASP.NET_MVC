using Dominio.Entidades;
using Dominio.Enums;
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
            builder.Property(i => i.ValorUnitario).IsRequired().HasColumnType("decimal");
            builder.Property(i => i.SubTotal).IsRequired().HasColumnType("decimal");
            builder.Property(i => i.StatusItem).HasConversion(y => y.ToString(), y => (EStatusItem)Enum.Parse(typeof(EStatusItem), y)).HasMaxLength(15).IsRequired();
        }
    }
}

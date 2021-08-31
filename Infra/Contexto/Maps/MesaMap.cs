using Dominio.Entidades;
using Dominio.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Contexto.Maps
{
    public class MesaMap : IEntityTypeConfiguration<Mesa>
    {
        public void Configure(EntityTypeBuilder<Mesa> builder)
        {
            builder.ToTable("Mesas");
            builder.HasKey(m => m.Id);
            builder.HasIndex(m => m.Numero);
            builder.Property(m => m.Numero).IsRequired().HasColumnType("int");
            builder.Property(m => m.QntCadeira).IsRequired().HasColumnType("int");
            builder.Property(m => m.QntCliente).IsRequired().HasColumnType("int");
            builder.Property(m => m.Status).HasConversion(y => y.ToString(), y => (EStatus)Enum.Parse(typeof(EStatus), y)).HasMaxLength(15).IsRequired();

            builder.HasMany(c => c.Clientes).WithOne(m => m.Mesa).HasForeignKey(m => m.MesaId);


        }
    }
}

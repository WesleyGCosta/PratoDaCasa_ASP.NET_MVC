using Dominio.Entidades;
using Dominio.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

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
            builder.Property(m => m.Cliente).IsRequired().HasMaxLength(30).HasColumnType("varchar(30)");
            builder.Property(m => m.Data).IsRequired().HasColumnType("date");
            builder.Property(m => m.Status).HasConversion(y => y.ToString(), y => (EStatusMesa)Enum.Parse(typeof(EStatusMesa), y)).HasMaxLength(15).IsRequired();

            builder.HasMany(c => c.Pedidos).WithOne(m => m.Mesa).HasForeignKey(m => m.MesaId);

        }
    }
}

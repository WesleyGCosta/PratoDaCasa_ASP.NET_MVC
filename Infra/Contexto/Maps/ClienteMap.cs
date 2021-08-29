using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Contexto.Maps
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.HoraChegada).IsRequired().HasColumnType("date");
            builder.Property(c => c.HoraSaida).IsRequired().HasColumnType("date");

            builder.HasMany(p => p.Pedidos).WithOne(c => c.Cliente).HasForeignKey(x => x.ClienteId);
        }
    }
}

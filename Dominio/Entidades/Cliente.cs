using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Cliente
    {
        public Cliente(Guid mesaId, 
            DateTime horaChegada, 
            DateTime horaSaida)
        {
            MesaId = mesaId;
            HoraChegada = horaChegada;
            HoraSaida = horaSaida;
        }

        public Guid Id {  get; private set; }
        public Guid MesaId {  get; private set; }
        public DateTime HoraChegada { get; private set; }
        public DateTime HoraSaida { get; private set; }

        public Mesa Mesa { get; private set; }
        public ICollection<Pedido> Pedidos {  get; private set; }


        public void AtualizarCliente(DateTime horachegada, DateTime horaSaida)
        {
            this.HoraChegada = horachegada;
            this.HoraSaida = horaSaida;
        }
    }
}

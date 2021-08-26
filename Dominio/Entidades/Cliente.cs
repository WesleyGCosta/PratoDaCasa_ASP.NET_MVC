using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Cliente
    {
        public Guid Id {  get; private set; }
        public Guid MesaId {  get; private set; }
        public string Nome { get; private set; }
        public DateTime HoraChegada { get; private set; }
        public DateTime HoraSainda { get; private set; }

        public Mesa Mesa { get; private set; }
        public ICollection<Pedido> Pedidos {  get; private set; }
    }
}

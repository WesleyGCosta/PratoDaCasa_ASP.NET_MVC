using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Mesa
    {
        public Guid Id { get; private set; }
        public int Numero { get; private set; }
        public int QntCadeira {  get; private set; }
        public EStatus Status {  get; private set; }
        public int QntCliente {  get; private set; }

        public ICollection<Cliente> Clientes {  get; private set; }
    }
}

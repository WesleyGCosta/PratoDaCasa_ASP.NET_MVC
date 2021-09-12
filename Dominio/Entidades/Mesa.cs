using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Mesa
    {
        public Mesa(int numero, string cliente, DateTime data, EStatusMesa status)
        {
            Numero = numero;
            Cliente = cliente;
            Data = data;
            Status = status;
            Pedidos = new List<Pedido>();
        }

        public Guid Id { get; private set; }
        public int Numero { get; private set; }
        public string Cliente {  get; private set; }
        public DateTime Data { get; private set;  }
        public EStatusMesa Status {  get; private set; }

        public virtual ICollection<Pedido> Pedidos { get; private set; }

        /*Métodos*/
        public void AtualizarMesa(int numero, 
            string cliente, 
            DateTime data,
            EStatusMesa status)
        {
            this.Numero = numero;
            this.Cliente = cliente;
            this.Data = data;
            this.Status = status;
        }

    }
}

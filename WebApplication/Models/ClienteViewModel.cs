using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {
            HoraChegada = DateTime.Now;
        }

        public Guid Id {  get; set; }
        public Guid MesaId { get; set; }
        public DateTime HoraChegada { get; set; }
        public DateTime HoraSaida { get; set; }

        public MesaViewModel MesaViewModel { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class ClienteViewModel
    {
        public Guid Id {  get; set; }
        public DateTime HoraChegada { get; set; }
        public DateTime HoraSaida { get; set; }

    }
}

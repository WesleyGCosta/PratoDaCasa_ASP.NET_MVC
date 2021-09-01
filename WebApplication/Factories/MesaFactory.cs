using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Factories
{
    public static class MesaFactory
    {
        public static MesaViewModel MapearMesaViewModel(Mesa mesa)
        {
            var mesaViewModel = new MesaViewModel
            {
                Id = mesa.Id,
                Numero = mesa.Numero,
                QntCadeira = mesa.QntCadeira,
                Status = mesa.Status,
                QntCliente = mesa.QntCliente
            };

            return mesaViewModel;
        }

        public static Mesa MapearMesa(MesaViewModel mesaViewModel)
        {
            var mesa = new Mesa(
                mesaViewModel.Numero,
                mesaViewModel.QntCadeira,
                mesaViewModel.Status,
                mesaViewModel.QntCliente
                );

            return mesa;
        }

        public static IEnumerable<MesaViewModel> MapearListaMesaViewModel(IEnumerable<Mesa> mesas)
        {
            var lista = new List<MesaViewModel>();
            foreach (var item in mesas)
            {
                lista.Add(MapearMesaViewModel(item));
            }

            return lista;
        }
        
    }
}

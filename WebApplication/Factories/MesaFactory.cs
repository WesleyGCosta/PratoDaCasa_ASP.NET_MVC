using Dominio.Entidades;
using System.Collections.Generic;
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
                Cliente = mesa.Cliente,
                Data = mesa.Data,
                Status = mesa.Status
            };

            return mesaViewModel;
        }

        public static Mesa MapearMesa(MesaViewModel mesaViewModel)
        {
            var mesa = new Mesa(
                mesaViewModel.Numero,
                mesaViewModel.Cliente,
                mesaViewModel.Data,
                mesaViewModel.Status
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

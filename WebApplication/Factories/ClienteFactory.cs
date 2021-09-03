using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Factories
{
    public class ClienteFactory
    {
        public static ClienteViewModel MapearClienteViewModel(Cliente cliente)
        {
            var clienteViewModel = new ClienteViewModel
            {
                Id = cliente.Id,
                MesaId = cliente.MesaId,
                HoraChegada = cliente.HoraChegada,
                HoraSaida = cliente.HoraSaida
            };

            return clienteViewModel;
        }

        public static Cliente MapearCliente(ClienteViewModel clienteViewModel)
        {
            var cliente = new Cliente(
                clienteViewModel.MesaId,
                clienteViewModel.HoraChegada,
                clienteViewModel.HoraSaida          
                );

            return cliente;
        }

        public static IEnumerable<ClienteViewModel> MapearListaClienteViewModel(IEnumerable<Cliente> clientes)
        {
            var lista = new List<ClienteViewModel>();
            foreach (var item in clientes)
            {
                lista.Add(MapearClienteViewModel(item));
            }

            return lista;
        }
    }
}

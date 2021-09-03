using Dominio.Entidades;
using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historia.Clientes
{
    public class AlterarCliente
    {
        private readonly IClienteRepository _clienteRepository;

        public AlterarCliente(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task Executar(Guid id, Cliente cliente)
        {
            var dadosDoCliente = await _clienteRepository.BuscarPoId(id);

            dadosDoCliente.AtualizarCliente(cliente.HoraChegada, cliente.HoraSaida);

            await _clienteRepository.Alterar(dadosDoCliente);
        }
    }
}

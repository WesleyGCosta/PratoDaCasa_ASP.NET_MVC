using Dominio.Entidades;
using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historia.Clientes
{
    public class AdicionarCliente
    {
        private readonly IClienteRepository _clienteRepository;
        public AdicionarCliente(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task Executar(Cliente cliente)
        {
            await _clienteRepository.Adicionar(cliente);
        }
    }
}

using Dominio.Entidades;
using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historia.Clientes
{
    public class DeletarCliente
    {
        private readonly IClienteRepository _clienteRepository;

        public DeletarCliente(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task Executar(Cliente cliente)
        {
            await _clienteRepository.Deletar(cliente);
        }
    }
}

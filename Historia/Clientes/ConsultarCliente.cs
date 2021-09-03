using Dominio.Entidades;
using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historia.Clientes
{
    public class ConsultarCliente
    {
        private readonly IClienteRepository _clienteRepository;

        public ConsultarCliente(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<Cliente> BuscarPorId(Guid id)
        {
            return await _clienteRepository.BuscarPoId(id);
        }

        public async Task<IEnumerable<Cliente>> BuscarTodos()
        {
            return await _clienteRepository.BuscarTodos();
        }
    }
}

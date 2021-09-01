using Dominio.Entidades;
using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historia.Mesas
{
    public class ConsultarMesa
    {
        private readonly IMesaRepository _mesaRepository;

        public ConsultarMesa(IMesaRepository imesaRepository)
        {
            _mesaRepository = imesaRepository;
        }

        public async Task<Mesa> BuscarPorId(Guid id)
        {
            return await _mesaRepository.BuscarPoId(id);
        }

        public async Task<IEnumerable<Mesa>> BuscarTodos()
        {
            return await _mesaRepository.BuscarTodos();
        }
    }
}

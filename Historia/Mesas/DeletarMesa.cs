using Dominio.Entidades;
using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historia.Mesas
{
    public class DeletarMesa
    {
        private readonly IMesaRepository _mesaRepository;

        public DeletarMesa(IMesaRepository mesaRepository)
        {
            _mesaRepository = mesaRepository;
        }

        public async Task Executar(Mesa mesa)
        {
            await _mesaRepository.Deletar(mesa);
        }
    }
}

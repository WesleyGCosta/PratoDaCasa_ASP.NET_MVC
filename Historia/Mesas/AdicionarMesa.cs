using Dominio.Entidades;
using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historia.Mesas
{
    public class AdicionarMesa
    {
        private readonly IMesaRepository _mesaRepository;
        public AdicionarMesa(IMesaRepository mesaRepository)
        {
            _mesaRepository = mesaRepository;
        }

        public async Task Executar(Mesa mesa)
        {
            await _mesaRepository.Adicionar(mesa);
        }
    }
}

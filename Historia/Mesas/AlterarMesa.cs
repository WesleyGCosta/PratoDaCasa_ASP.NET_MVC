using Dominio.Entidades;
using Dominio.IRepositories;
using System;
using System.Threading.Tasks;

namespace Historia.Mesas
{
    public class AlterarMesa
    {
        private readonly IMesaRepository _mesaRepository;

        public AlterarMesa(IMesaRepository mesaRepository)
        {
            _mesaRepository = mesaRepository;
        }

        public async Task Executar(Guid id, Mesa mesa)
        {
            var dadosDaMesa = await _mesaRepository.BuscarPoId(id);

            dadosDaMesa.AtualizarMesa(mesa.Numero,
                dadosDaMesa.Cliente,
                dadosDaMesa.Data,
                dadosDaMesa.Status);

            await _mesaRepository.Alterar(dadosDaMesa);
            
        }
    }
}

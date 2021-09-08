using Dominio.IRepositories;
using Historia.Mesas;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebApplication.Factories;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class MesaController : Controller
    {
        private readonly AdicionarMesa _adicionarMesa;
        private readonly AlterarMesa _alterarMesa;
        private readonly ConsultarMesa _consultarMesa;
        private readonly DeletarMesa _deletarMesa;

        public MesaController(IMesaRepository mesaRepository)
        {
            _adicionarMesa = new AdicionarMesa(mesaRepository);
            _alterarMesa = new AlterarMesa(mesaRepository);
            _consultarMesa = new ConsultarMesa(mesaRepository);
            _deletarMesa = new DeletarMesa(mesaRepository);

        }

        public async Task<IActionResult> Index()
        {
            var listaMesas = await _consultarMesa.BuscarTodos();
            var ListarMesasViewModel = MesaFactory.MapearListaMesaViewModel(listaMesas);

            return View(ListarMesasViewModel);
        }

        public IActionResult Adicionar()
        {
            //MesaViewModel mesa = new MesaViewModel();
            return PartialView("_AdicionarMesa"/*, mesa*/);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Adicionar(MesaViewModel mesaViewModel)
        {
            if (ModelState.IsValid)
            {
                var mesa = MesaFactory.MapearMesa(mesaViewModel);

                await _adicionarMesa.Executar(mesa);

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Alterar(Guid id)
        {
            var mesa = await _consultarMesa.BuscarPorId(id);

            if (mesa == null)
            {
                return RedirectToAction("Index");
            }

            var mesaViewModel = MesaFactory.MapearMesaViewModel(mesa);

            return PartialView("_AlterarMesa", mesaViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Alterar(Guid id, MesaViewModel mesaViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(mesaViewModel);
            }

            var mesa = MesaFactory.MapearMesa(mesaViewModel);

            await _alterarMesa.Executar(id, mesa);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detalhar(Guid id)
        {
            var mesa = await _consultarMesa.BuscarPorId(id);

            if (mesa == null)
            {
                return RedirectToAction("Index");
            }

            var mesaViewModel = MesaFactory.MapearMesaViewModel(mesa);

            return PartialView("_DetalhesDaMesa", mesaViewModel);
        }

        public async Task<IActionResult> Deletar(Guid id)
        {
            var mesa = await _consultarMesa.BuscarPorId(id);

            if (mesa == null)
            {
                return RedirectToAction("Index");
            }

            await _deletarMesa.Executar(mesa);

            return RedirectToAction("Index");
        }
    }
}

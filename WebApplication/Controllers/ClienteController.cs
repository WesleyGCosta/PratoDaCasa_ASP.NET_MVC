using Dominio.IRepositories;
using Historia.Clientes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Factories;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class ClienteController : Controller
    {
        private readonly AdicionarCliente _adicionarCliente;
        private readonly AlterarCliente _alterarCliente;
        private readonly ConsultarCliente _consultarCliente;
        private readonly DeletarCliente _deletarCliente;

        public ClienteController(IClienteRepository clienteRepository)
        {
            _adicionarCliente = new AdicionarCliente(clienteRepository);
            _alterarCliente = new AlterarCliente(clienteRepository);
            _consultarCliente = new ConsultarCliente(clienteRepository);
            _deletarCliente = new DeletarCliente(clienteRepository);

        }

        public async Task<IActionResult> Index()
        {
            var ListaClientes = await _consultarCliente.BuscarTodos();
            var ListarClientesViewModel = ClienteFactory.MapearListaClienteViewModel(ListaClientes);

            return View(ListarClientesViewModel);
        }

        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Adicionar(ClienteViewModel clienteViewModel)
        {
            if (ModelState.IsValid)
            {
                var cliente = ClienteFactory.MapearCliente(clienteViewModel);

                await _adicionarCliente.Executar(cliente);

                return RedirectToAction("Index");
            }

            return View(clienteViewModel);
        }


        //aqui
        public async Task<IActionResult> Alterar(Guid id)
        {
            var cliente = await _consultarCliente.BuscarPorId(id);

            if (cliente == null)
            {
                return RedirectToAction("Index");
            }

            var autorViewModel = ClienteFactory.MapearClienteViewModel(cliente);

            return View(autorViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Alterar(Guid id, ClienteViewModel clienteViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(clienteViewModel);
            }

            var autor = ClienteFactory.MapearCliente(clienteViewModel);

            await _alterarCliente.Executar(id, autor);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detalhar(Guid id)
        {
            var cliente = await _consultarCliente.BuscarPorId(id);

            if (cliente == null)
            {
                return RedirectToAction("Index");
            }

            var autorViewModel = ClienteFactory.MapearClienteViewModel(cliente);

            return View(autorViewModel);
        }

        public async Task<IActionResult> Deletar(Guid id)
        {
            var cliente = await _consultarCliente.BuscarPorId(id);

            if (cliente == null)
            {
                return RedirectToAction("Index");
            }


            await _deletarCliente.Executar(cliente);

            return RedirectToAction("Index");
        }
    }
}

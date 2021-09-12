using Dominio.IRepositories;
using Historia.Mesas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Factories;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ConsultarMesa _consultarMesa;

        public HomeController(ILogger<HomeController> logger, IMesaRepository mesaRepository)
        {
            _logger = logger;
            _consultarMesa = new ConsultarMesa(mesaRepository);
        }

        public async Task<IActionResult> Index()
        {
            var listaMesas = await _consultarMesa.BuscarTodos();
            var ListarMesasViewModel = MesaFactory.MapearListaMesaViewModel(listaMesas);

            return View(ListarMesasViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using QuadrMedalhasService.Interface;
using QuadrMedalhasService.Payload;
using QuadroMedalhas.Models;
using QuadroMedalhasRepository.DTO;
using System.Diagnostics;

namespace QuadroMedalhas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IQuadroMedalhaService quadroMedalhaService;
        private readonly IGerarDados gerarDados;

        public HomeController(ILogger<HomeController> logger, IQuadroMedalhaService quadroMedalhaService, IGerarDados gerarDados)
        {
            _logger = logger;
            this.quadroMedalhaService = quadroMedalhaService;
            this.gerarDados = gerarDados;
        }


        public IActionResult Buscar()
        {
           var payload = new QuadroMedalhaPayload() { codigo = 1, codigoAtleta = 1, siglePais = "BR", codigomodalidade = 1, siglamedalha = "OU", medalha = "OURO" };
            quadroMedalhaService.SalvarQuadroMedalha(payload);

            quadroMedalhaService.BuscarQuadroMedalhas();
            return View("Index", gerarDados.Lista);
        }
        public IActionResult Index()
        {
            var lista = new List<QuadroMedalhaDTO>();
            lista.AddRange(gerarDados.AcrescentarDados("BR", 10, 103 , 15));
            lista.AddRange(gerarDados.AcrescentarDados("EUA", 54, 45 , 25));
            lista.AddRange(gerarDados.AcrescentarDados("CHI", 22, 50 , 65));
            lista.AddRange(gerarDados.AcrescentarDados("ARG", 3, 3 , 35));
            gerarDados.Lista.AddRange(lista);
            return View(lista);
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
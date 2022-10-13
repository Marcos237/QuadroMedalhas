using QuadrMedalhasService.Interface;
using QuadrMedalhasService.Payload;

namespace QuadroMedalhas
{
    public  class Startup
    {
        private readonly IQuadroMedalhaService quadroMedalhaService;
        public Startup(IQuadroMedalhaService quadroMedalhaService)
        {
            this.quadroMedalhaService = quadroMedalhaService;
        }
        public void SalvarQuadroMedalhas()
        {

            var quadro = new QuadroMedalhaPayload() { codigoAtleta = 1, siglamedalha = "OU", codigomodalidade = 1, siglePais = "BR" };
            quadroMedalhaService.SalvarQuadroMedalha(quadro);

            var dados = quadroMedalhaService.BuscarQuadroMedalhas();
            Console.WriteLine(dados);
        }
    }
}

using QuadrMedalhasService.Adpater;
using QuadrMedalhasService.Interface;
using QuadrMedalhasService.Payload;
using QuadroMedalhasRepository.DTO;
using QuadroMedalhasDomain.Service.Interface;

namespace QuadrMedalhasService
{
    public class QuadroMedalhaService : IQuadroMedalhaService
    {
        private readonly IQuadroMedalhaDomainService quadroMedalhaDomainService;
        private readonly IGerarDados gerarDados;

        public QuadroMedalhaService(IQuadroMedalhaDomainService quadroMedalhaDomainService, IGerarDados gerarDados)
        {
            this.quadroMedalhaDomainService = quadroMedalhaDomainService;
            this.gerarDados = gerarDados;
        }
        public List<QuadroMedalhaDTO> BuscarQuadroMedalhas()
        {
            var dados = quadroMedalhaDomainService.BuscarQuadroMedalhas();
            var quadro = new QuadroMedalhaDTO() { pais = "BR" };
            var qntMedalha = new MedalhaDTO() { descricao = "OURO",  Quantidade = 1 };
            quadro.medalhas = new List<MedalhaDTO>();
            quadro.medalhas.Add(qntMedalha);

            foreach (var item in gerarDados.Lista)
            {
                foreach (var tipo in item.medalhas)
                {
                    if (tipo.descricao == "OURO" && item.pais == "BR")
                        tipo.Quantidade += qntMedalha.Quantidade;
                }
            }
            return gerarDados.Lista;
        }

        public bool SalvarQuadroMedalha(QuadroMedalhaPayload quadroMedalhaPayload)
        {
            var convertToQuadroMedalha = new ConvertToQuadroMedalha();
            var quadroMedalha = convertToQuadroMedalha.ConverterParaQuadroMedalha(quadroMedalhaPayload);


            return quadroMedalhaDomainService.SalvarQuadroMedalha(quadroMedalha);
        }

    }
}

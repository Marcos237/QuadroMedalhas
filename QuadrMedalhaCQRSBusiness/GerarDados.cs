using QuadrMedalhasService.Interface;
using QuadroMedalhasDomain;
using QuadroMedalhasRepository.DTO;

namespace QuadrMedalhasService
{
    public class GerarDados : IGerarDados
    {
        public List<QuadroMedalhaDTO> Lista { get; set; }
        public GerarDados()
        {
            Lista = new List<QuadroMedalhaDTO>();
        }

        public List<QuadroMedalhaDTO> AcrescentarDados(string pais, int qntOuro, int qntPrata, int qntBronze)
        {
            var lista = new List<QuadroMedalhaDTO>();    
            var medalhas1 = new MedalhaDTO() { descricao = "OURO", Quantidade = qntOuro };
            var medalhas2 = new MedalhaDTO() { descricao = "PRATA", Quantidade = qntPrata };
            var medalhas3 = new MedalhaDTO() { descricao = "BRONZE", Quantidade = qntBronze };
            var payload = new QuadroMedalhaDTO() { pais = pais };
            payload.medalhas = new List<MedalhaDTO>();
            payload.medalhas.Add(medalhas1);
            payload.medalhas.Add(medalhas2);
            payload.medalhas.Add(medalhas3);
            lista.Add(payload);
            return lista;
        }
    }
}

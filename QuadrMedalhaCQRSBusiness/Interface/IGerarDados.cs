using QuadroMedalhasRepository.DTO;

namespace QuadrMedalhasService.Interface
{
    public interface IGerarDados
    {
        List<QuadroMedalhaDTO> AcrescentarDados(string pais, int qntOuro, int qntPrata, int qntBronze);
        public List<QuadroMedalhaDTO> Lista { get; set; }
    }
}

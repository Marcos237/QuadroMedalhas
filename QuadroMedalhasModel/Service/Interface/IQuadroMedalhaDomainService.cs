using QuadroMedalhasRepository.DTO;

namespace QuadroMedalhasDomain.Service.Interface
{
    public  interface IQuadroMedalhaDomainService
    {
        bool SalvarQuadroMedalha(QuadroMedalha quadroMedalha);
        List<QuadroMedalhaDTO> BuscarQuadroMedalhas();
    }
}

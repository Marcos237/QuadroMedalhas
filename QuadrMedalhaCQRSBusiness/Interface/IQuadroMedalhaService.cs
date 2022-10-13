using QuadrMedalhasService.Payload;
using QuadroMedalhasRepository.DTO;

namespace QuadrMedalhasService.Interface
{
    public interface IQuadroMedalhaService
    {
        bool SalvarQuadroMedalha(QuadroMedalhaPayload quadroMedalha);
        List<QuadroMedalhaDTO> BuscarQuadroMedalhas();
    }
}

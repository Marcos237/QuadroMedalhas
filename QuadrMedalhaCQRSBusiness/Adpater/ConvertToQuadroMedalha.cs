using QuadrMedalhasService.Payload;
using QuadroMedalhasDomain;

namespace QuadrMedalhasService.Adpater
{
    public class ConvertToQuadroMedalha
    {
        public QuadroMedalha ConverterParaQuadroMedalha(QuadroMedalhaPayload quadroMedalhaPayload)
        {
            var quadroMedalha = new QuadroMedalha()
            {
                codigo = quadroMedalhaPayload.codigo,
                codigoAtleta = quadroMedalhaPayload.codigoAtleta,
                siglePais = quadroMedalhaPayload.siglePais,
                siglamedalha = quadroMedalhaPayload.siglamedalha,
                codigomodalidade = quadroMedalhaPayload.codigomodalidade,
            };
            return quadroMedalha;
        }
    }
}

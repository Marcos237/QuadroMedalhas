using MongoDB.Bson;
using QuadroMedalhasCQRSRepository.Interface;
using QuadroMedalhasRepository.DTO;
using QuadroMedalhasDomain.Service.Interface;

namespace QuadroMedalhasDomain.Service
{
    public class QuadroMedalhaDomainService : IQuadroMedalhaDomainService
    {
        private readonly ISqlRepository<QuadroMedalha> quadroMedalhaRepository;
        private readonly IMongoRepository quadroMedalhaMongoRepository;
        public QuadroMedalhaDomainService(ISqlRepository<QuadroMedalha> quadroMedalhaRepository, IMongoRepository quadroMedalhaMongoRepository)
        {
            this.quadroMedalhaRepository = quadroMedalhaRepository;
            this.quadroMedalhaMongoRepository = quadroMedalhaMongoRepository;
        }
        public List<QuadroMedalhaDTO> BuscarQuadroMedalhas()
        {
            var medalhas = quadroMedalhaMongoRepository.BuscarQuadoMedalhas();
            return medalhas.ToList();
        }

        public bool SalvarQuadroMedalha(QuadroMedalha quadroMedalha)
        {
            var retorno = quadroMedalhaRepository.Salvar(quadroMedalha);

            var doc = new BsonDocument() {
                {"codigo", quadroMedalha.codigo },
                {"siglaPais", quadroMedalha.siglePais },
                {"siglamedalha", quadroMedalha.siglamedalha },
                };
            retorno = quadroMedalhaMongoRepository.Salvar(doc);
            return retorno;
        }
    }
}

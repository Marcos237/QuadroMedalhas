using MongoDB.Bson;
using QuadroMedalhasCQRSRepository.Interface;
using QuadroMedalhasRepository.DTO;

namespace QuadroMedalhasRepository
{
    public class MongoRepository : IMongoRepository
    {

        public IEnumerable<QuadroMedalhaDTO> BuscarQuadoMedalhas()
        {
           return new List<QuadroMedalhaDTO>();
        }

        public bool Salvar(BsonDocument doc)
        {
            return true;
        }
    }
}

using MongoDB.Bson;
using QuadroMedalhasRepository.DTO;

namespace QuadroMedalhasCQRSRepository.Interface
{
    public interface IMongoRepository
    {
        IEnumerable<QuadroMedalhaDTO> BuscarQuadoMedalhas();
        bool Salvar(BsonDocument doc);
    }
}

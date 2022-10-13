using MongoDB.Bson;

namespace QuadroMedalhasCQRSRepository.Interface
{
    public interface ISqlRepository<T> where T : class 
    {
        bool Salvar(T entity);
    }
}

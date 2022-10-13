using QuadroMedalhasCQRSRepository.Interface;

namespace QuadroMedalhasRepository
{
    public class SqlRepository<T> : ISqlRepository<T> where T : class
    {
        private readonly IMongoRepository mongoRepository;
        public SqlRepository(IMongoRepository mongoRepository)
        {
            this.mongoRepository = mongoRepository;
        }
        public bool Salvar(T entity)
        {

            return true;
        }
    }
}


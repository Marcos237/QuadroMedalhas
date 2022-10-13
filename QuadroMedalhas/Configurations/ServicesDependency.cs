using QuadrMedalhasService;
using QuadrMedalhasService.Interface;
using QuadroMedalhasCQRSRepository.Interface;
using QuadroMedalhasDomain.Service;
using QuadroMedalhasDomain.Service.Interface;
using QuadroMedalhasRepository;

namespace QuadroMedalhas.Configurations
{
    public static class ServicesDependency
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped(typeof(ISqlRepository<>), typeof(SqlRepository<>));

            services.AddScoped<IMongoRepository, MongoRepository>();
            services.AddScoped<IQuadroMedalhaDomainService, QuadroMedalhaDomainService>();
            services.AddScoped<IQuadroMedalhaService, QuadroMedalhaService>();

            services.AddSingleton<IGerarDados, GerarDados>();
        }
    }
}


using Microsoft.Extensions.DependencyInjection;
using QuadrMedalhasService;
using QuadrMedalhasService.Interface;
using QuadroMedalhasCQRSRepository.Interface;
using QuadroMedalhasDomain.Service;
using QuadroMedalhasDomain.Service.Interface;
using QuadroMedalhasRepository;

var services = new ServiceCollection();
services.AddScoped(typeof(ISqlRepository<>), typeof(SqlRepository<>));
services.AddScoped<IMongoRepository, MongoRepository>();
services.AddScoped<IQuadroMedalhaDomainService, QuadroMedalhaDomainService>();
services.AddScoped<IQuadroMedalhaService, QuadroMedalhaService>();


foreach (var item in services)
{
    var teste = item.ServiceType.;
}
int i = 0;
////Startup startup = new Startup();
//startup.SalvarQuadroMedalhas();





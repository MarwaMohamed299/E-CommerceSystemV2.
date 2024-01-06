using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;

namespace E_CommerceSystemV2.API.SqlLocalizerProvider
{
    /*Here there is a small problem as the context require a scoped service while ISringLocalizer
     require a Singleton so to resolve this i needed to use IServiceScopeFactory to create a custom scope for the context 
    in bothe create method*/
    public class SqlLocalzerFactory : IStringLocalizerFactory
    {
        private readonly IServiceScopeFactory _serviceScoprFactory;

        public SqlLocalzerFactory(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScoprFactory = serviceScopeFactory;
        }

        public IStringLocalizer Create(Type resourcesSource)/*P.S Dependency Injection by a Function*/
        {
            using (var scope = _serviceScoprFactory.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ECommerceContext>();
                return new SqlLocalizer(context);
            }
        }

        public IStringLocalizer Create(string baseName, string location)
        {
            using (var scope = _serviceScoprFactory.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ECommerceContext>();
                return new SqlLocalizer(context);
            };
        }
    }
}

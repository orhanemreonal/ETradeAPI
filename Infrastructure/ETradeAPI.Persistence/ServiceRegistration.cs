using ETradeAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ETradeAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETradeAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));

            //services.AddSingleton<IProductService, ProductService>();


        }
    }
}

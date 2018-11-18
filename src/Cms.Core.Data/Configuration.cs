using Cms.Core.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Cms.Core.Data
{
    public static class Configuration
    {
        public static IServiceCollection SetCmsDatabase(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<CmsContext>(options => options.UseSqlServer(connectionString));

            return services;
        }
    }
}
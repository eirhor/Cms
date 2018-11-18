using Cms.Core.Identity.Contexts;
using Cms.Core.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Cms.Core.Identity
{
    public static class Configuration
    {
        public static IServiceCollection ConfigureIdentity<TUser>(this IServiceCollection services, string connectionString) where TUser: UserData
        {
            services
                .AddDbContext<CmsIdentityContext<TUser>>(options => options.UseSqlServer(connectionString))
                .AddIdentity<TUser, IdentityRole>()
                .AddEntityFrameworkStores<CmsIdentityContext<TUser>>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(Options.ApplyDefaultIdentityOptions);
            services.ConfigureApplicationCookie(Options.ApplyDefaultCookieOptions);

            return services;
        }
    }
}
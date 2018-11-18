using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Web
{
    public static class InitializationExtensions
    {
        public static IServiceCollection AddCmsWeb(this IServiceCollection services)
        {
            var optionsSetup = new ConfigureOptions<RazorViewEngineOptions>(options =>
            {
                // TODO: Add providers for CMS as described here: https://github.com/aspnet/AspNetCore/issues/1490#issuecomment-221676623
            });

            services.AddSingleton<IConfigureOptions<RazorViewEngineOptions>>(optionsSetup);

            return services;
        }
    }
}
using Microsoft.EntityFrameworkCore;
using myWebApp.Data;

namespace myWebApp.Startup
{
    public static partial class ServiceInitializer
    {
        public static IServiceCollection RegisterApplicationServices(
                                        this IServiceCollection services, ConfigurationManager configuration)
        {
            RegisterDb(services, configuration);

            RegisterCustomDependencies(services);

            RegisterSwagger(services);
            RegisterHttpClientDependencies(services);

            return services;
        }

        private static void RegisterDb(IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddDbContext<SchoolContext>(options =>
               options.UseNpgsql(configuration.GetConnectionString("SchoolContext")));

        }

        private static void RegisterCustomDependencies(IServiceCollection services)
        {
            //services.AddTransient<IChuckNorrisRespositoryAPI, ChuckNorrisRespositoryAPI>();

        }

        private static void RegisterHttpClientDependencies(IServiceCollection services)
        {
            // services.AddHttpClient<IChuckNorrisRespositoryAPI, ChuckNorrisRespositoryAPI>();
        }
        private static void RegisterSwagger(IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            //services.AddSwaggerGen();
        }
    }
}

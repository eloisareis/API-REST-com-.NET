using Microsoft.Extensions.DependencyInjection;
using Services;
using User;

namespace DependencyInjection;

public class ConfigureService
{
    public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient<IUserService, UserService>();
    }
}

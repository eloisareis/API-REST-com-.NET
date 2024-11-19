using Context;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository;

namespace DependencyInjection;

public class ConfigureRepository
{
    public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

        serviceCollection.AddDbContext<MyContext>(
            options => options.UseMySql(
                "Server=localhost;Port=3306;DataBase=dbAPI;Uid=root;Pwd=eloisa",
                ServerVersion.AutoDetect("Server=localhost;Port=3306;DataBase=dbAPI;Uid=root;Pwd=eloisa")
            )
        );
    }
}

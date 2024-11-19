using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Context;

public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
{
    public MyContext CreateDbContext(string[] args)
    {
        //Usado para Criar as Migrações
        var connectionString = "Server=localhost;Port=3306;DataBase=dbAPI;Uid=root;Pwd=eloisa";
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 403));
        var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
        optionsBuilder.UseMySql(connectionString, serverVersion);
        return new MyContext(optionsBuilder.Options);
    }
}

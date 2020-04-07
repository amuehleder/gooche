using Autofac;
using AzureFunctions.Autofac.Configuration;
using Microsoft.Extensions.Configuration;
using gooche.Dal;
using gooche.Logic;
using System;
using Microsoft.EntityFrameworkCore;

namespace gooche.Function
{
    public class AutofacStartup
    {
        public AutofacStartup(string functionName)
        {
            DependencyInjection.Initialize(builder =>
            {
                IConfigurationRoot config = new ConfigurationBuilder()
                  .SetBasePath(Environment.CurrentDirectory)
                  .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
                  .AddEnvironmentVariables()
                  .Build();

                var connectionString = config.GetConnectionString("goocheDB");
                DbContextOptions<goocheContext> dbContextOptions = null;
                    dbContextOptions = new DbContextOptionsBuilder<goocheContext>().UseSqlServer(connectionString).Options;

                builder.RegisterType<goocheContext>().AsSelf()
                       .WithParameter(new TypedParameter(typeof(DbContextOptions<goocheContext>), dbContextOptions));

                builder.RegisterType<AccountLogic>().As<IAccountLogic>();
                builder.RegisterType<UsersRepository>().As<IUsersRepository>();
                builder.RegisterType<MenuLogic>().As<IMenuLogic>();
                builder.RegisterType<MenuRepository>().As<IMenuRepository>();
            },
            functionName);
        }
    }
}

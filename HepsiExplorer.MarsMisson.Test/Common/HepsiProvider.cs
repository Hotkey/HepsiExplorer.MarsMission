using HepsiExplorer.MarsMisson.Console.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace HepsiExplorer.MarsMisson.Console
{
    public class HepsiProvider
    {
        public static ServiceProvider Configure()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<IVehicle, MarsRover>();
            //services.AddTransient<IPlanet, Mars>();
            services.AddTransient<ILand, Plateau>();
            services.AddTransient<ICommand, TurnLeft>();
            services.AddTransient<ICommand, TurnRight>();
            services.AddTransient<ICommand, Move>();
            services.AddTransient<ICommander, Commander>();
            return services.BuildServiceProvider();
        }
    }
}

using HepsiExplorer.MarsMisson.Console.Exceptions;
using Microsoft.Extensions.DependencyInjection;

namespace HepsiExplorer.MarsMisson.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcome to mars
            // take the "plateau name"
            // take the "plateau size (20x30)"
            // You are in the "xx plateau"
            // You are at "0,0,N"
            // Configure Dependencies
            var hepsiProvider = HepsiProvider.Configure();
            var plateau = hepsiProvider.GetService<ILand>();
            var marsRover = hepsiProvider.GetService<IVehicle>();
            var command = hepsiProvider.GetService<ICommand>();
            System.Console.WriteLine("Welcome to the Red Planet!");
            System.Console.WriteLine("Please input plateu size: ");
            string gridSize = System.Console.ReadLine();
            System.Console.WriteLine("Should i start the rover engine? Y/N");
            string answer = System.Console.ReadLine();
            if (answer.ToUpper().Equals("Y"))
            {
                bool isEngineStarted = marsRover.EngineStart();
                if (isEngineStarted)
                    System.Console.WriteLine("Engine launched successfully...");
                else
                    throw new EngineException("Engine failed","Exception Message");

                bool areaCreated = plateau.CreateArea(gridSize);
                if (areaCreated)
                {
                    System.Console.WriteLine("Plateau was created successfully...");
                    System.Console.WriteLine("Your rover's current coords [0,0,N]");
                    System.Console.WriteLine("Target Position for Rover {x y d} :");
                    var targetPosition = System.Console.ReadLine();
                    System.Console.WriteLine("Target Command for Rover (L,R,M) :");
                    var targetCommand = System.Console.ReadLine();
                    marsRover.Land = plateau;
                    // Setup position command
                    marsRover.SetupPosition(targetPosition);
                    // Take commands
                    marsRover.TakeCommands(targetCommand.ToCharArray());
                    plateau.Vehicles.Add(marsRover);
                    foreach (var vehicle in plateau.Vehicles)
                    {
                        var commander = hepsiProvider.GetService<ICommander>();
                        commander.Vehicle = vehicle;
                        commander.Land = plateau;
                        foreach (var commandItem in vehicle.CommandList)
                        {
                            commander.AddCommand(commandItem);
                        }
                        // Apply given commands
                        commander.RunCommand();
                        // Final PosX
                        int x = commander.Vehicle.PosX;
                        // Final PosY
                        int y = commander.Vehicle.PosY;
                        // Final Direction
                        var direct = commander.Vehicle.Direction;
                        System.Console.WriteLine($"Result: {x} {y} {direct.ToString()}");
                        System.Console.ReadKey();
                    }
                }
                else
                {
                    Main(args);
                }
            }
            else
            {
                System.Console.WriteLine("Exit...");
            }
        }

    }
}

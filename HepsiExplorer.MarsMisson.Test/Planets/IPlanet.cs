using HepsiExplorer.MarsMisson.Console.Models;
namespace HepsiExplorer.MarsMisson.Console
{
    public interface IPlanet
    {
        bool Initialize();

        PlanetBaseModel GetPlanet();
    }
}

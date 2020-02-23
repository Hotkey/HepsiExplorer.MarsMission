using HepsiExplorer.MarsMisson.Console.Models;
using System;

namespace HepsiExplorer.MarsMisson.Console.Planets
{
    public class Mars : IPlanet
    {
        public bool Initialize()
        {
            throw new NotImplementedException();
        }

        public PlanetBaseModel GetPlanet()
        {
            return new MarsModel() { };
        }
    }
}

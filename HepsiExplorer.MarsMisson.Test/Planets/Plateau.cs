using System;
using System.Collections.Generic;

namespace HepsiExplorer.MarsMisson.Console
{
    public class Plateau : ILand
    {
        public int LandX { get; set; }
        public int LandY { get; set; }
        public IList<IVehicle> Vehicles { get; set; }

        public Plateau()
        {
            this.Vehicles = new List<IVehicle>();
        }

        public Plateau(int x, int y)
        {
            this.LandX = x;
            this.LandY = y;
        }

        public void CreateArea(int x, int y)
        {
            this.LandX = x;
            this.LandY = y;
        }

        public bool CreateArea(string input)
        {
            bool result = false;
            if (string.IsNullOrEmpty(input) || input.Length < 3)
                return result;

            var areaSize = input.Split(' ');
            if (areaSize.Length < 2)
                return result;

            int landX, landY;
            if (int.TryParse(areaSize[0], out landX))
            {
                if (int.TryParse(areaSize[1], out landY))
                {
                    this.LandX = landX;
                    this.LandY = landY;
                    result = true;
                }
            }
            return result;
        }
    }
}

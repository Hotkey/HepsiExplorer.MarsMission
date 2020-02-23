using System.Collections.Generic;

namespace HepsiExplorer.MarsMisson.Console
{
    public interface ILand
    {
        int LandX { get; set; }
        int LandY { get; set; }
        void CreateArea(int x, int y);
        bool CreateArea(string input);
        IList<IVehicle> Vehicles { get; set; }
    }
}

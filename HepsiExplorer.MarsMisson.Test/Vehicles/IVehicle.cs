using System.Collections.Generic;

namespace HepsiExplorer.MarsMisson.Console
{
    public interface IVehicle
    {
        ILand Land { get; set; }
        IList<ICommand> CommandList { get; set; }
        bool EngineStart();
        void TurnRight();
        void TurnLeft();
        void Move();
        void SetupPosition(string input);
        void TakeCommands(char[] commandArr);
        public int PosX { get; set; }
        public int PosY { get; set; }
        public Directions Direction { get; set; }
    }
}

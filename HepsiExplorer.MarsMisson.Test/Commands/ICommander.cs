namespace HepsiExplorer.MarsMisson.Console
{
    public interface ICommander
    {
        ILand Land { get; set; }
        IVehicle Vehicle { get; set; }
        void AddCommand(ICommand command);
        void RunCommand();
    }
}

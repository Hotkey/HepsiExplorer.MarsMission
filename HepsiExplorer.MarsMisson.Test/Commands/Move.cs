namespace HepsiExplorer.MarsMisson.Console.Commands
{

    /// <summary>
    /// Move command
    /// </summary>
    public partial class Move : ICommand
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// 
        /// </summary>
        private readonly IVehicle _vehicle;

        /// <summary>
        /// 
        /// </summary>
        public Move()
        {
            this.Name = "MoveCommand";
            this.Description = "Used to go forward";
            this.Order = -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vehicle"></param>
        public Move(IVehicle vehicle)
        {
            this._vehicle = vehicle;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Apply()
        {
            this._vehicle.Move();
        }
    }
}

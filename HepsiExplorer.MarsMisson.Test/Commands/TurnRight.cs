namespace HepsiExplorer.MarsMisson.Console.Commands
{
    /// <summary>
    /// TurnRight command
    /// </summary>
    public partial class TurnRight : ICommand
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
        public TurnRight()
        {
            this.Name = "TurnRightCommand";
            this.Description = "Used for turning to right";
            this.Order = -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vehicle"></param>
        public TurnRight(IVehicle vehicle)
        {
            this._vehicle = vehicle;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Apply()
        {
            this._vehicle.TurnRight();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiExplorer.MarsMisson.Console.Commands
{
    /// <summary>
    /// TurnLeft command
    /// </summary>
    public partial class TurnLeft : ICommand
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
        public TurnLeft()
        {
            this.Name = "TurnLeftCommand";
            this.Description = "Used for turning to left";
            this.Order = -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vehicle"></param>
        public TurnLeft(IVehicle vehicle)
        {
            this._vehicle = vehicle;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Apply()
        {
            this._vehicle.TurnLeft();
        }
    }
}

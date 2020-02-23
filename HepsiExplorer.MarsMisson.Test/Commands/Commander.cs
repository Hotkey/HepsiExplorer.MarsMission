using System.Collections.Generic;

namespace HepsiExplorer.MarsMisson.Console
{
    public partial class Commander : ICommander
    {
        public ILand Land { get; set; }
        public IVehicle Vehicle { get; set; }
        
        private Queue<ICommand> CommandQueue;

        public Commander()
        {
            this.CommandQueue = new Queue<ICommand>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public void AddCommand(ICommand command)
        {
            CommandQueue.Enqueue(command);
        }

        /// <summary>
        /// 
        /// </summary>
        public void RunCommand()
        {
            while (CommandQueue.Count > 0)
            {
                ICommand command = CommandQueue.Dequeue();
                command.Apply();
            }
        }
    }
}

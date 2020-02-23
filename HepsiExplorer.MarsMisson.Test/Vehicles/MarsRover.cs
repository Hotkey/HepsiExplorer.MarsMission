using System;
using System.Collections.Generic;
using HepsiExplorer.MarsMisson.Console.Commands;

namespace HepsiExplorer.MarsMisson.Console
{
    public partial class MarsRover : IVehicle
    {

        private bool _isLaunched;
        public int PosX { get; set; }
        public int PosY { get; set; }
        public Directions Direction { get; set; }
        public ILand Land { get; set; }
        public IList<ICommand> CommandList { get; set; }
        private Directions CurrentDirection { get; set; }
        public bool EngineStart()
        {
            // TODO : Check something about rover and engine etc..
            this.CommandList = new List<ICommand>();
            // Default Direction
            this.Direction = this.CurrentDirection = Directions.N;
            this.PosX = this.PosY = 0;
            _isLaunched = true;
            return _isLaunched;
        }

        /// <summary>
        /// Rover spin 90 degrees to Right
        /// </summary>
        public void TurnRight()
        {
            switch (CurrentDirection)
            {
                case Directions.N:
                    CurrentDirection = Directions.E;
                    break;
                case Directions.E:
                    CurrentDirection = Directions.S;
                    break;
                case Directions.S:
                    CurrentDirection = Directions.W;
                    break;
                case Directions.W:
                    CurrentDirection = Directions.N;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Rover spin 90 degrees to Left
        /// </summary>
        public void TurnLeft()
        {
            switch (CurrentDirection)
            {
                case Directions.N:
                    CurrentDirection = Directions.W;
                    break;
                case Directions.E:
                    CurrentDirection = Directions.N;
                    break;
                case Directions.S:
                    CurrentDirection = Directions.E;
                    break;
                case Directions.W:
                    CurrentDirection = Directions.S;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Don't change direction and move forward
        /// </summary>
        public void Move()
        {
            switch (CurrentDirection)
            {
                case Directions.N:
                    this.PosY++; 
                    break;
                case Directions.E:
                    this.PosX++;
                    break;
                case Directions.S:
                    this.PosY--;
                    break;
                case Directions.W:
                    this.PosX--;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        public void SetupPosition(string input)
        {
            var position = input.Split(' ');
            if (position.Length == 3)
            {
                try
                {
                    int x = int.Parse(position[0]);
                    int y = int.Parse(position[1]);
                    string direction = position[2].ToUpper();
                    Directions d;
                    if (Enum.TryParse<Directions>(direction, out d))
                    {
                        PosX = x;
                        PosY = y;
                        Direction = CurrentDirection = d;
                    }
                }
                catch (Exception err)
                {

                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commandArr"></param>
        public void TakeCommands(char[] commandArr)
        {
            foreach (char command in commandArr)
            {
                var parsedEnum = Enum.Parse<CommandEnum>(Enum.GetName(typeof(CommandEnum), command));
                switch (parsedEnum)
                {
                    case CommandEnum.Right:
                        this.CommandList.Add(new TurnRight(this));
                        break;
                    case CommandEnum.Left:
                        this.CommandList.Add(new TurnLeft(this));
                        break;
                    case CommandEnum.Move:
                        this.CommandList.Add(new Move(this));
                        break;
                    default:
                        throw new Exception();
                }

            }
        }
    }
}

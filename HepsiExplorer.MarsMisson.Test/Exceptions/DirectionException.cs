using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiExplorer.MarsMisson.Console.Exceptions
{
    [Serializable]
    public class DirectionException : Exception
    {

        public DirectionException()
        {

        }

        public DirectionException(string directionInfo, string message) : base($"Invalid Direction: {directionInfo}. Exception: {message}")
        {

        }
    }
}

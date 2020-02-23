using System;

namespace HepsiExplorer.MarsMisson.Console.Exceptions
{
    [Serializable]
    public class PositionException : Exception
    {
        public PositionException()
        {

        }

        public PositionException(string positionInput, string message) : base($"Invalid Position: {positionInput}. Exception: {message}")
        {

        }
    }
}

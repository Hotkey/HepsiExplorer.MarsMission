using System;

namespace HepsiExplorer.MarsMisson.Console.Exceptions
{
    [Serializable]
    public class EngineException : Exception
    {
        public EngineException()
        {

        }

        public EngineException(string engineInfo, string message) : base($"Invalid Engine Status: {engineInfo}. Exception: {message}")
        {

        }
    }
}

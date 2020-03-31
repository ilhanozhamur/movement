using System;

namespace HepsiBuradaProj.Helper
{
   [Serializable] 
    public class RoverDeployException : Exception
    {
        public RoverDeployException(string message) : base(message) {}
    }
}
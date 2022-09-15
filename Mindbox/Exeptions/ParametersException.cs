namespace Mindbox.Exeptions 
{
    using System;

    public class ParametersException : Exception 
    {
        public ParametersException(string message) : base(message)
        {
        }
    }
}

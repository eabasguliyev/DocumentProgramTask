using System;

namespace DocumentProgram
{
    public class ProgramKeyException : ApplicationException
    {
        public ProgramKeyException(string message):base(message)
        {
        }
    }
}
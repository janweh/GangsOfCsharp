using System;

namespace WindowsFormsApp15.Data
{
    class DuplicateDataException : Exception
    {
        public DuplicateDataException()
        {
        }

        public DuplicateDataException(string message) 
            : base(message)
        {
        }

        public DuplicateDataException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}

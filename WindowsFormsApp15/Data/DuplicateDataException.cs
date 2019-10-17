using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

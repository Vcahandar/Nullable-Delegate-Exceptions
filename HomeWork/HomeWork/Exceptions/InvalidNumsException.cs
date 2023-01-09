using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Exceptions
{
    internal class InvalidNumsException : Exception
    {
        public InvalidNumsException(string massage) : base(massage) { }
        
    }
}

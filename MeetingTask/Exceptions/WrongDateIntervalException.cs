using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingTask.Exceptions
{
    internal class WrongDateIntervalException : Exception
    {
        public WrongDateIntervalException(string message):base(message)
        { 
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.SingletonPattern.NonPatternVersion
{
    public class Logger
    {
        private Logger() { }

        // Factory method, that returns a new Logger instance.
        public static Logger GetLogger()
        {
            return new Logger();
        }

        public void WriteLogMessage(string message)
        {
            
        }
    }
}

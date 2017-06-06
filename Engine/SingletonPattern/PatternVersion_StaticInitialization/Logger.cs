using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.SingletonPattern.PatternVersion_StaticInitialization
{
    public sealed class Logger
    {
        private static readonly Logger _Logger = new Logger();
        private Logger() { }

        /// <summary>
        /// Static initialization technique.
        /// </summary>
        /// <returns></returns>
        public static Logger GetLogger()
        {
            return _Logger;
        }

        public void WriteMessage(string message)
        {
            
        }
    }
}

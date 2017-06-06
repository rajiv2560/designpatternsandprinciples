using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.SingletonPattern.PatternVersion_DoubleLock
{
    public sealed class Logger
    {
        private static Logger _logger;
        private static readonly object _obj = new object();
        private Logger() { }

        /// <summary>
        /// Double-locking technique.
        /// </summary>
        /// <returns></returns>
        public static Logger GetLogger()
        {
            if (_logger == null)
            {
                lock (_obj)
                {
                    if (_logger == null)
                    {
                        _logger = new Logger();
                    }
                }
            }

            return _logger;
        }

        public void WriteMessage(string message) { }
    }
}

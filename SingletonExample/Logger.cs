using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public class Logger
    {
        private static Logger _logger;

        private Logger() { }

        public static Logger CrateAsSingleton()
        {
            if (_logger == null)
            {
                _logger = new Logger();
            }

            return _logger;
        }

        public void Info(string message)
        {
            Console.WriteLine(@"Info - {message}");
        }
        public void Error(string message)
        {
            Console.WriteLine(@"Error - {message}");
        }
    }
}

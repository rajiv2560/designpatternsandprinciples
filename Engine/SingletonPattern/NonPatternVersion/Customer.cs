using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.SingletonPattern.NonPatternVersion
{
    public class Customer
    {
        private readonly Logger _logger;

        public string Name { get; set; }

        public Customer(string name)
        {
            _logger = Logger.GetLogger();
            Name = name;
        }

        public void UpdateAddress(string street, string city)
        {
            // Update the database with updated streed and city...

            // Write to log.
            _logger.WriteLogMessage($"Updated the address for: {Name} at: {DateTime.Now}");
        }
    }
}

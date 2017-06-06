using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Follow
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sourceServerData = new List<SourceServerData>();
            var serverData = new List<ServerData>();

            foreach (var data in serverData)
            {
                var sourceData = sourceServerData.FirstOrDefault(s => s.RecordIdentifier == data.RecordIdentifier);
                var isValid = IsValid(data, sourceData);
                Console.WriteLine("Record with Id {0} is {1}", data.RecordIdentifier, isValid);
                Console.ReadLine();
            }
        }

        private static object IsValid(ServerData data, SourceServerData sourcedData)
        {
            List<IValidator> validators = AddValidatorsToValidate();
            IValidateData validateData = new ValidateData(validators);
            return validateData.Validate(data, sourcedData);
        }

        private static List<IValidator> AddValidatorsToValidate()
        {
            return new List<IValidator>
            {
                new IpValidator(),
                new TypeValidator()
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Follow
{
    public class TypeValidator : IValidator
    {
        public bool IsValid(ServerData data, SourceServerData sourceData)
        {
            return data.Type == sourceData.Type;
        }
    }
}

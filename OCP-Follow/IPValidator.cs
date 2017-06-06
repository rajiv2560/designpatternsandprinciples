using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Follow
{
    public class IpValidator : IValidator
    {
        public bool IsValid(ServerData data, SourceServerData sourceData)
        {
            return data.Ip != sourceData.Ip;
        }
    }
}

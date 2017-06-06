using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Follow
{
    public interface IValidateData
    {
        bool Validate(ServerData data, SourceServerData sourceData);
    }
}

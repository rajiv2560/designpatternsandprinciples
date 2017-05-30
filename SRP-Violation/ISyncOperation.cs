using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Violation
{
    interface ISyncOperation
    {
        void Connect(string serverName);
        void Sync();
        bool Store();
        bool Save();
    }
}

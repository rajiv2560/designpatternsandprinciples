using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Follow
{
    public interface ITempStoreRepository
    {
        bool Store(InternalServerData data);
    }
}

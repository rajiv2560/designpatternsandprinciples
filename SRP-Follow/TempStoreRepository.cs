using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Follow
{
    public class TempStoreRepository : ITempStoreRepository
    {
        public bool Store(InternalServerData data)
        {
            // logic to store data in temp storage.
            return true;
        }
    }
}

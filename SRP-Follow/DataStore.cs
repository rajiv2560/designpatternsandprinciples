using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Follow
{
    /// <summary>
    /// Store data in temporary storage.
    /// </summary>
    public class DataStore
    {
        private readonly ITempStoreRepository _repository;

        public DataStore(ITempStoreRepository repository)
        {
            _repository = repository;
        }

        public bool Store(IEnumerable<ExternalServerData> data)
        {
            var isSuccess = false;
            foreach (var d in data)
            {
                isSuccess = _repository.Store(ToInternalServerData(d));
            }
            return isSuccess;
        }

        private InternalServerData ToInternalServerData(ExternalServerData data)
        {
            return new InternalServerData();
        }
    }
}

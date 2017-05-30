using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Follow
{
    public class SyncOperation
    {
        private IList<ExternalServerData> _data;
        private DataStore _dataStore;
        private DatabaseServer _dbServer;
        private IExternalServerDataRepository _repository;

        public SyncOperation(IList<ExternalServerData> data, IExternalServerDataRepository repository, DatabaseServer dbServer)
        {
            _data = data;
            _repository = repository;
            _dbServer = dbServer;
            _dataStore = new DataStore(new TempStoreRepository());
        }

        public void Sync()
        {
            // Sart syncing of data as per requested server
            _dataStore.Store(_repository.Sync());
        }
    }
}

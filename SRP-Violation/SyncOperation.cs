using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Violation
{
    public class SyncOperation : ISyncOperation
    {
        /// <summary>
        /// Connection to the external server.
        /// </summary>
        /// <param name="serverName">Server Name to be connected.</param>
        public void Connect(string serverName)
        {
            // TODO-logic to connect external database.
            // Refer to http://www.connectionstrings.com/
        }

        /// <summary>
        /// Sync with external data
        /// </summary>
        public void Sync()
        {
            // Start syncing external data
        }

        /// <summary>
        /// Stored synced
        /// </summary>
        /// <returns></returns>
        public bool Store()
        {
            // Store syncd data in temporary storage
            return true;
        }

        /// <summary>
        /// Save data from the temporary storage.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Permanently persist data from temporary storerage.
            // This is the final operation.
            return true;
        }
    }
}

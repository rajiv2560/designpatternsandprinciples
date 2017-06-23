using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Violation
{
    /// <summary>
    /// This class is doing two things
    /// i. Validating the data.
    /// ii. Saving the data.
    /// This class is open for new additions or operations, and if we want to extend it, that will be a tedious job and would have to modify
    /// the IsValid method. Also, if we need to modity the behavior in order to persist data, we would need to change the actual class.
    /// Therefore, this code is not following OCP.
    /// </summary>
    public class ValidateData
    {
        public void SyncronizeData(ServerData data, SourceServerData sourceData)
        {
            if (IsValid(data, sourceData))
            {
                // First validata data and then send to persist.
            }
        }

        private bool IsValid(ServerData data, SourceServerData sourceData)
        {
            var result = false;

            Debug.Assert(data != null, "data != null");
            if (data.Type == sourceData.Type)
                result = true;
            if (data.Ip != sourceData.Ip)
                result = true;

            // add other validation logics/rules to validate incoming data
            return result;
        }
    }
}

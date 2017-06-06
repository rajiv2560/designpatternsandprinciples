using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Violation
{
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

            if (data.Type == sourceData.Type)
                result = true;
            if (data.Ip != sourceData.Ip)
                result = true;

            // add other validation logics
            return result;
        }
    }
}

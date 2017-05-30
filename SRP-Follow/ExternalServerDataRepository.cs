using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Follow
{
    public class ExternalServerDataRepository : IExternalServerDataRepository
    {
        public readonly List<ExternalServerData> _dataList = GetServerData();

        public IEnumerable<ExternalServerData> Sync()
        {
            return _dataList;
        }

        private static List<ExternalServerData> GetServerData()
        {
            return new List<ExternalServerData>(new []
            {
                new ExternalServerData()
                {
                    Id = 1,
                    InitialatDate = new DateTime(2017, 06, 01),
                    EndDate = new DateTime(2017, 06, 30),
                    OrderNumbr = 1,
                    IsDirty = false,
                    Type = 1,
                    IpAddress = "127.0.0.1"
                },
                new ExternalServerData()
                {
                    Id = 2, 
                    InitialatDate   = new DateTime(2017, 06, 15),
                    EndDate = new DateTime(2017, 06, 30),
                    OrderNumbr = 2,
                    IsDirty = true,
                    Type = 1,
                    IpAddress = "127.0.0.1"
                }
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Follow
{
    public class ExternalServerData
    {
        public int Id { get; set; }
        public DateTime InitialatDate { get; set; }
        public DateTime EndDate { get; set; }
        public int OrderNumbr { get; set; }
        public bool IsDirty { get; set; }
        public string IpAddress { get; set; }
        public int Type { get; set; }
        public int RecordIdentifier { get; set; }
    }
}

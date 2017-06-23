using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Follow
{
    public class Manager
    {
        private IDeveloper _developer;

        public void SetDeveloper(IDeveloper developer)
        {
            _developer = developer;
        }

        public void Manage()
        {
            _developer.WriteCode();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Violation
{
    public class Manager
    {
        private AssociateDeveloper _developer;

        public void SetDeveloper(AssociateDeveloper developer)
        {
            _developer = developer;
        }

        public void Manage()
        {
            _developer.WriteCode();
        }
    }
}

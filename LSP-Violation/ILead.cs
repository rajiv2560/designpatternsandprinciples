using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Violation
{
    interface ILead
    {
        void CreateTask();
        void AssignTask();
        void WorkOnTask();
    }
}

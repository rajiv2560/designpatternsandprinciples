using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Violation
{
    public class TeamLead : ILead
    {
        public void CreateTask()
        {
            // Implementation to create task for the developers
        }

        public void AssignTask()
        {
            // Implementation to assign task to the developers
        }

        public void WorkOnTask()
        {
            // Implementation to work on task for the team leader.
        }
    }
}

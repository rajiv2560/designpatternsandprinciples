using System;

namespace ISP_Violation
{
    public class Manager : ILead
    {
        public void CreateTask()
        {
            // Implementation to create tasks 
        }

        public void AssignTask()
        {
            // Implementation to assign task
        }

        public void WorkOnTask()
        {
            throw  new Exception("Manager can't work on user story/task.");
        }
    }
}

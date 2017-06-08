using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.MVVMPattern.PatternVersion.Models;

namespace Engine.MVVMPattern.PatternVersion.ViewModels
{
    public class StudentViewModel
    {
        public StudentModel Students { get; set; }

        public StudentViewModel()
        {
            Students = new StudentModel();
        }

        public void DisplayStudents()
        {
            Students.DisplayStudents();
        }
    }
}

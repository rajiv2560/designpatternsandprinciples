using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Engine.Annotations;

namespace Engine.MVVMPattern.PatternVersion.Models
{
    public class StudentModel : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged(nameof(FirstName));
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    OnPropertyChanged(nameof(LastName));
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }

        public string FullName => _firstName + " " + _lastName;

        public ObservableCollection<StudentModel> Students { get; set; }

        public void DisplayStudents()
        {
            var students = new ObservableCollection<StudentModel>
            {
                new StudentModel {FirstName = "Rajiv", LastName = "Shrestha"},
                new StudentModel {FirstName = "Mark", LastName = "Sears"}
            };

            Students = students;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

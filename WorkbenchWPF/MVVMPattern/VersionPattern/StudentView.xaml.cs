using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Engine.MVVMPattern.PatternVersion.ViewModels;

namespace WorkbenchWPF.MVVMPattern.VersionPattern
{
    /// <summary>
    /// Interaction logic for StudentView.xaml
    /// </summary>
    public partial class StudentView1 : Window
    {
        private readonly StudentViewModel _studentViewModel = new StudentViewModel();
        public StudentView1()
        {
            InitializeComponent();

            DataContext = _studentViewModel;
            _studentViewModel.DisplayStudents();
        }
    }
}

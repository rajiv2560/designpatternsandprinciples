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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Engine.MVVMPattern.PatternVersion.ViewModels;
using WorkbenchWPF.MVVMPattern.NonPatternVersion;
using WorkbenchWPF.MVVMPattern.VersionPattern;

namespace WorkbenchWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnClick_MVVMPattern_NonPatternVersion_VerifyPassword(object sender, RoutedEventArgs e)
        {
            var view = new MVVMPattern.NonPatternVersion.AccountCreationView();
            view.ShowDialog();
        }

        private void OnClick_MVVMPattern_PatternVersion__VerifyPassword(object sender, RoutedEventArgs e)
        {
            var view = new MVVMPattern.VersionPattern.AccountCreationView();
            view.ShowDialog();
        }

        private void OnClick_MVVMPattern_PatternVersion_StudentDetails(object sender, RoutedEventArgs e)
        {
            var view = new StudentView();
            view.ShowDialog();
        }
    }
}

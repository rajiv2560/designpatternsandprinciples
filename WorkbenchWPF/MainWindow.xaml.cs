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

        private void OnClick_MVVMPattern_NonPatternVersion(object sender, RoutedEventArgs e)
        {
            MVVMPattern.NonPatternVersion.AccountCreationView view = new MVVMPattern.NonPatternVersion.AccountCreationView();
            view.ShowDialog();
        }

        private void OnClick_MVVMPattern_PatternVersion(object sender, RoutedEventArgs e)
        {
            MVVMPattern.VersionPattern.AccountCreationView view = new MVVMPattern.VersionPattern.AccountCreationView();
            view.ShowDialog();
        }
    }
}

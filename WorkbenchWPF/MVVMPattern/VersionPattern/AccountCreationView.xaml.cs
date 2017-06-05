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
    /// Interaction logic for AccountCreationView.xaml
    /// </summary>
    public partial class AccountCreationView : Window
    {
        private readonly AccountCreationViewModel _accountCreationViewModel = new AccountCreationViewModel();

        public AccountCreationView()
        {
            InitializeComponent();

            DataContext = _accountCreationViewModel;
        }

        private void OnClick_ValidatePassword(object sender, RoutedEventArgs e)
        {
            _accountCreationViewModel.ValidatePassword();
        }
    }
}

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

namespace WorkbenchWPF.MVVMPattern.NonPatternVersion
{
    /// <summary>
    /// Interaction logic for AccountCreationView.xaml
    /// </summary>
    public partial class AccountCreationView : Window
    {
        public AccountCreationView()
        {
            InitializeComponent();
        }

        private void OnClick_ValidatePassword(object sender, RoutedEventArgs e)
        {
            if (TxtPassword.Text.Trim().Length < 8)
            {
                LblErrorMessage.Text = "Password must be at least eight characters long";
            }
            else if (TxtPassword.Text.Trim().Length > 20)
            {
                LblErrorMessage.Text = "Password cannot be more than twenty characters long";
            }
            else if (!TxtPassword.Text.Any(char.IsUpper))
            {
                LblErrorMessage.Text = "Password must contain at least one upper-case character";
            }
            else if (!TxtPassword.Text.Any(char.IsLower))
            {
                LblErrorMessage.Text = "Password must contain at least one lower-case character";
            }
            else if (!TxtPassword.Text.Any(char.IsNumber))
            {
                LblErrorMessage.Text = "Password must contain at least one number";
            }
            else
            {
                LblErrorMessage.Text = "Password is secure";
            }
        }
    }
}

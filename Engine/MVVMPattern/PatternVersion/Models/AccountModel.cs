using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Engine.Annotations;

namespace Engine.MVVMPattern.PatternVersion.Models
{
    public class AccountModel : INotifyPropertyChanged
    {
        private string _userName;
        private string _passwword;
        private string _validationMessage;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string Password
        {
            get { return _passwword; }
            set
            {
                _passwword = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public string ValidationMessage
        {
            get { return _validationMessage; }
            set
            {
                _validationMessage = value;
                OnPropertyChanged(nameof(ValidationMessage));
            }
        }

        public void ValidatePassword()
        {
            if (Password == null)
            {
                ValidationMessage = "Password must be at least eight characters long";
            }
            else if (Password.Trim().Length < 8)
            {
                ValidationMessage = "Password must be at least eight characters long";
            }
            else if (Password.Trim().Length > 20)
            {
                ValidationMessage = "Password cannot be more than twenty characters long";
            }
            else if (!Password.Any(char.IsUpper))
            {
                ValidationMessage = "Password must contain at least one upper-case character";
            }
            else if (!Password.Any(char.IsLower))
            {
                ValidationMessage = "Password must contain at least one lower-case character";
            }
            else if (!Password.Any(char.IsNumber))
            {
                ValidationMessage = "Password must contain at least one number";
            }
            else
            {
                ValidationMessage = "Password is secure";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.MVVMPattern.PatternVersion.Models;

namespace Engine.MVVMPattern.PatternVersion.ViewModels
{
    public class AccountCreationViewModel
    {
        public AccountModel NewAccount { get; set; }

        public AccountCreationViewModel()
        {
            NewAccount = new AccountModel();
        }

        public void ValidatePassword()
        {
            NewAccount.ValidatePassword();
        }
    }
}

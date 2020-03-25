using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gooche.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {
        public AccountViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Account";
        }
    }
}

using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gooche.ViewModels
{
    public class AccountPageViewModel : ViewModelBase
    {
        public AccountPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Account";
        }
    }
}

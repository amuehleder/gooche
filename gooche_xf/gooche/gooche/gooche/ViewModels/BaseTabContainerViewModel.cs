using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gooche.ViewModels
{
    public class BaseTabContainerViewModel : ViewModelBase
    {
        public BaseTabContainerViewModel(INavigationService navService)
            : base(navService)
        {
            Title = "gooche";
        }
    }
}

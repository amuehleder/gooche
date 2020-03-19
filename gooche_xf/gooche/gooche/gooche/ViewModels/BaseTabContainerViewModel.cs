using gooche.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gooche.ViewModels
{
    public class BaseTabContainerViewModel : ViewModelBase
    {
        private IEssentialsService essentialsService { get; }

        public BaseTabContainerViewModel(INavigationService navService, IEssentialsService essentialsSvc)
            : base(navService)
        {
            Title = "gooche";
            essentialsService = essentialsSvc;
            Task.Run(async () => {
                await InitUserLocation();
            }); 
        }

        private async Task InitUserLocation()
        {
            await essentialsService.GetUserPosition();
        }
    }
}

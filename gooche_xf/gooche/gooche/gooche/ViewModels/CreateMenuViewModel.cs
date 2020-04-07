using gooche.Interfaces;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace gooche.ViewModels
{
    public class CreateMenuViewModel : ViewModelBase, IActiveAware
    {
        private INavigationService navigationService { get; }

        public event EventHandler IsActiveChanged;

        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set { SetProperty(ref _isActive, value, RaiseIsActiveChanged); }
        }
        private IItemsModel itemsModel { get; }
        private IAccountService accountService { get; }

        private string menuName;

        public string MenuName
        {
            get => menuName;
            set => SetProperty(ref menuName, value);
        }

        private DateTime from;

        public DateTime From
        {
            get => from;
            set => SetProperty(ref from, value);
        }

        private DateTime to;

        public DateTime To
        {
            get => to;
            set => SetProperty(ref to, value);
        }

        private double price;

        public double Price
        {
            get => price;
            set => SetProperty(ref price, value);
        }

        private bool isVegetarian;

        public bool IsVegetarian
        {
            get => isVegetarian;
            set => SetProperty(ref isVegetarian, value);
        }

        private bool isVegan;

        public bool IsVegan
        {
            get => isVegan;
            set => SetProperty(ref isVegan, value);
        }

        private Command onCreateMenuCommand;

        public Command OnCreateMenuCommand
        {
            get => onCreateMenuCommand;
            set => SetProperty(ref onCreateMenuCommand, value);
        }

        public CreateMenuViewModel(INavigationService navService, IItemsModel itemsMdl, IAccountService accountSvc)
            : base(navService)
        {
            Title = "CreateMenu";
            navigationService = navService;
            itemsModel = itemsMdl;
            accountService = accountSvc;
            onCreateMenuCommand = new Command(async () =>
            {
                var user = accountService.GetUserData();
                var userPosition = accountService.GetCurrentUserPosition();
                if(user != null && userPosition != null)
                {
                    var IsSuccessful = await itemsModel.CreateMenu(new Classes.Menu(user.UserID, menuName, from, to, price, userPosition.Latitude, userPosition.Longitude, isVegetarian, isVegan));
                }
            });

            IsActiveChanged += (s, e) =>
            {
                if (!accountService.GetUserLoggedIn())
                {
                    navigationService.NavigateAsync("LoginPage", useModalNavigation: true);
                }
            };
        }

        protected virtual void RaiseIsActiveChanged()
        {
            IsActiveChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}

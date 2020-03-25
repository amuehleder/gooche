using gooche.Classes;
using gooche.Interfaces;
using Prism.Navigation;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace gooche.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private ILoginModel loginModel { get; }

        private INavigationService navigationService { get; }

        private Command onLoginCommand;

        public Command OnLoginCommand
        {
            get => onLoginCommand;
            set => SetProperty(ref onLoginCommand, value);
        }

        private Command onRegisterCommand;

        public Command OnRegisterCommand
        {
            get => onRegisterCommand;
            set => SetProperty(ref onRegisterCommand, value);
        }

        private string userName;
        public string UserName
        {
            get => userName;
            set => SetProperty(ref userName, value);
        }

        private string password;
        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        public LoginViewModel(INavigationService navService, ILoginModel loginMdl)
            : base(navService)
        {
            Title = "gooche";
            navigationService = navService;
            loginModel = loginMdl;
            onLoginCommand = new Command(async () =>
            {
                var IsSuccessful = await loginModel.Login(new LoginParameters(UserName, Password));
                if (IsSuccessful)
                {
                    await navigationService.NavigateAsync("NavigationPage/BaseTabContainerPage", useModalNavigation: true);
                }
            });

            onRegisterCommand = new Command(async () =>
            {
                await navigationService.NavigateAsync("RegisterPage", useModalNavigation: true);
            });
        }
    }
}

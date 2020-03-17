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

        private Command onLoginCommand;

        public Command OnLoginCommand
        {
            get => onLoginCommand;
            set => SetProperty(ref onLoginCommand, value);
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
            loginModel = loginMdl;
            onLoginCommand = new Command(() =>
            {
                loginModel.Login(new LoginParameters(UserName, Password));
            });
        }
    }
}

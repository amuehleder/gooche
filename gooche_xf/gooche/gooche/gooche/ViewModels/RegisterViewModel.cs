using gooche.Classes;
using gooche.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace gooche.ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {
        private IRegisterModel registerModel { get; }

        private DateTime birthDate;

        public DateTime BirthDate
        {
            get => birthDate;
            set => SetProperty(ref birthDate, value);
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

        private string email;

        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }

        private Command onRegisterCommand;

        public Command OnRegisterCommand
        {
            get => onRegisterCommand;
            set => SetProperty(ref onRegisterCommand, value);
        }

        public RegisterViewModel(INavigationService navigationService, IRegisterModel registerMdl)
            : base(navigationService)
        {
            Title = "Register";
            registerModel = registerMdl;
            birthDate = DateTime.Now;
            onRegisterCommand = new Command(async () =>
            {
                if (userName != null && birthDate != null && email != null && password != null)
                {
                    if(await registerModel.Register(new UserData(userName, birthDate, email, password)))
                    {
                        await navigationService.GoBackAsync();
                    }
                }
            });
        }
    }
}

using Prism;
using Prism.Ioc;
using gooche.ViewModels;
using gooche.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using gooche.Models;
using gooche.Interfaces;
using gooche.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace gooche
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("LoginPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginViewModel>();
            containerRegistry.RegisterSingleton<ILoginModel ,LoginModel>();
            containerRegistry.RegisterSingleton<IHttpService ,HttpService>();
            containerRegistry.RegisterSingleton<IAccountService, AccountService>();
            containerRegistry.RegisterForNavigation<BaseTabContainerPage, BaseTabContainerViewModel>();
            containerRegistry.RegisterForNavigation<ItemsPage, ItemsViewModel>();
            containerRegistry.RegisterForNavigation<AccountPage, AccountViewModel>();
            containerRegistry.RegisterSingleton<IItemsModel, ItemsModel>();
            containerRegistry.RegisterSingleton<IEssentialsService, EssentialsService>();
            containerRegistry.RegisterForNavigation<RegisterPage, RegisterViewModel>();
            containerRegistry.RegisterSingleton<IRegisterModel, RegisterModel>();

        }
    }
}

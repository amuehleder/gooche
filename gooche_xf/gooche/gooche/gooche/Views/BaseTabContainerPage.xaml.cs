using Xamarin.Forms;

namespace gooche.Views
{
    public partial class BaseTabContainerPage : TabbedPage
    {
        public BaseTabContainerPage()
        {
            InitializeComponent();
            Children.Add(new ItemsPage());
            Children.Add(new CreateMenuPage());
            Children.Add(new AccountPage());
        }
    }
}

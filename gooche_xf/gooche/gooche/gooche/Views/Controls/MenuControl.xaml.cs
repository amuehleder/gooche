using gooche.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace gooche.Views.Controls
{
    public partial class MenuControl : ViewCell, INotifyPropertyChanged
    {

        public static readonly BindableProperty UserProperty =
        BindableProperty.Create("User", typeof(UserData), typeof(MenuControl), null);

        public static readonly BindableProperty MenuNameProperty =
            BindableProperty.Create("MenuName", typeof(string), typeof(MenuControl), String.Empty);

        public static readonly BindableProperty FromProperty =
            BindableProperty.Create("From", typeof(DateTime), typeof(MenuControl));

        public static readonly BindableProperty ToProperty =
            BindableProperty.Create("To", typeof(DateTime), typeof(MenuControl));

        public UserData User
        {
            get { return (UserData)GetValue(UserProperty); }
            set { SetValue(UserProperty, value); }
        }

        public string MenuName
        {
            get { return (string)GetValue(MenuNameProperty); }
            set { SetValue(MenuNameProperty, value); }
        }

        public DateTime From
        {
            get { return (DateTime)GetValue(FromProperty); }
            set { SetValue(FromProperty, value); }
        }

        public DateTime To
        {
            get { return (DateTime)GetValue(ToProperty); }
            set { SetValue(ToProperty, value); }
        }

        public MenuControl()
        {
            InitializeComponent();
        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
        }
    }
}
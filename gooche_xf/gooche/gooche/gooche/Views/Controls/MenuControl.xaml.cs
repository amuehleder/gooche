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
            BindableProperty.Create("From", typeof(DateTime), typeof(MenuControl), null);

        public static readonly BindableProperty ToProperty =
            BindableProperty.Create("To", typeof(DateTime), typeof(MenuControl), null);

        public static readonly BindableProperty PriceProperty =
            BindableProperty.Create("Price", typeof(double), typeof(MenuControl), 0d);

        public static readonly BindableProperty IsVegetarianProperty =
            BindableProperty.Create("IsVegetarian", typeof(bool), typeof(MenuControl), false);

        public static readonly BindableProperty IsVeganProperty =
            BindableProperty.Create("IsVegan", typeof(bool), typeof(MenuControl), false);

        public string DateFromTo
        {
            get => dateFromTo;
            set => dateFromTo = value;
        }

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

        public double Price
        {
            get { return (double)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }
        public bool IsVegetarian
        {
            get { return (bool)GetValue(IsVegetarianProperty); }
            set { SetValue(IsVegetarianProperty, value); }
        }

        public bool IsVegan
        {
            get { return (bool)GetValue(IsVeganProperty); }
            set { SetValue(IsVeganProperty, value); }
        }

        public string FormattedPrice { get; set; }

        private string dateFromTo;
        
        private string formattedPrice;
        

        public MenuControl()
        {
            InitializeComponent();
        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            switch (propertyName)
            {
                case nameof(To):
                    if (From != null)
                    {
                        DateFromTo = $"{From.ToString("dd MMMM yyyy hh:mm")} - {To.ToString("hh:mm")}";
                    }
                    break;
                case nameof(From):
                    if (To != null)
                    {
                        DateFromTo = $"{From.ToString("dd MMMM yyyy hh:mm")} - {To.ToString("hh:mm")}";
                    }
                    break;
                case nameof(Price):
                    FormattedPrice = $"{Price.ToString()} €";
                    break;
            }
            base.OnPropertyChanged(propertyName);
        }
    }
}
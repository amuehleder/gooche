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
    public partial class LabelDateTimeControl : StackLayout, INotifyPropertyChanged
    {
        public static readonly BindableProperty NameProperty =
           BindableProperty.Create("Name", typeof(string), typeof(LabelEntryControl), String.Empty);

        public static readonly BindableProperty DateTimeProperty =
            BindableProperty.Create("DateTime", typeof(DateTime), typeof(LabelEntryControl), DateTime.Now);

        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        public DateTime DateTime
        {
            get { return (DateTime)GetValue(DateTimeProperty); }
            set { SetValue(DateTimeProperty, value); }
        }

        public LabelDateTimeControl()
        {
            InitializeComponent();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
        }
    }
}
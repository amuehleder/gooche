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
    public partial class LabelEntryControl : StackLayout, INotifyPropertyChanged
    {
        public static readonly BindableProperty NameProperty =
           BindableProperty.Create("Name", typeof(string), typeof(LabelEntryControl), String.Empty);

        public static readonly BindableProperty IsPasswordProperty =
            BindableProperty.Create("IsPassword", typeof(bool), typeof(LabelEntryControl), false);

        public static readonly BindableProperty InputProperty =
           BindableProperty.Create("Input", typeof(string), typeof(LabelEntryControl), String.Empty);

        public static readonly BindableProperty KeyboardTypeProperty =
           BindableProperty.Create("KeyBoardType", typeof(Keyboard), typeof(LabelEntryControl), Keyboard.Default);

        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        public bool IsPassword
        {
            get { return (bool)GetValue(IsPasswordProperty); }
            set { SetValue(IsPasswordProperty, value); }
        }

        public string Input
        {
            get { return (string)GetValue(InputProperty); }
            set { SetValue(InputProperty, value); }
        }

        public Keyboard KeyboardType
        {
            get { return (Keyboard)GetValue(KeyboardTypeProperty); }
            set { SetValue(KeyboardTypeProperty, value); }
        }

        public LabelEntryControl()
        {
            InitializeComponent();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
        }
    }
}
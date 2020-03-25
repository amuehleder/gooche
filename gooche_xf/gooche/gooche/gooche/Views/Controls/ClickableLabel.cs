using Prism.Behaviors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace gooche.Views.Controls
{
    public class ClickableLabel : Label, INotifyPropertyChanged
    {
        public static readonly BindableProperty TappedCommandProperty =
            BindableProperty.Create("TappedCommand", typeof(Command), typeof(ClickableLabel), null);

        public Command TappedCommand
        {
            get { return (Command)GetValue(TappedCommandProperty); }
            set { SetValue(TappedCommandProperty, value); }
        }

        public ClickableLabel()
        {
            
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if(propertyName == nameof(TappedCommand))
            {
                if(TappedCommand != null)
                {
                    var tapGestureRecognizer = new TapGestureRecognizer();
                    tapGestureRecognizer.Tapped += (s, e) =>
                    {
                        TappedCommand.Execute(null);
                    };
                    GestureRecognizers.Add(tapGestureRecognizer);
                }
            }
            base.OnPropertyChanged(propertyName);
        }
    }
}

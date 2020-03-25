using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace gooche.Classes
{
    public class Menu
    {
        public UserData User { get; }
        public string MenuName { get; }
        public DateTime From { get; }
        public DateTime To { get; }
        public double Price { get; }
        public double Latitude { get; }
        public double Longitude { get; }
        public bool IsVegetarian { get; }
        public bool IsVegan { get; }

        public Menu(UserData user, string menuName, DateTime from, DateTime to, double price, double latitude, double longitude, bool isVegetarian = false, bool isVegan = false)
        {
            User = user;
            MenuName = menuName;
            From = from;
            To = to;
            Price = price;
            Latitude = latitude;
            Longitude = longitude;
            IsVegetarian = isVegetarian;
            IsVegan = isVegan;
        }
    }
}

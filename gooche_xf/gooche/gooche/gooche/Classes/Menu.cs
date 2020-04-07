using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace gooche.Classes
{
    public class Menu
    {
        public int MenuId { get; }
        public int UserId { get; }
        public string MenuName { get; }
        public DateTime ActiveFrom { get; }
        public DateTime ActiveTo { get; }
        public double Price { get; }
        public double Latitude { get; }
        public double Longitude { get; }
        public bool IsVegetarian { get; }
        public bool IsVegan { get; }

        public Menu(int user, string menuName, DateTime activeFrom, DateTime activeTo, double price, double latitude, double longitude, bool isVegetarian = false, bool isVegan = false)
        {
            UserId = user;
            MenuName = menuName;
            ActiveFrom = activeFrom;
            ActiveTo = activeTo;
            Price = price;
            Latitude = latitude;
            Longitude = longitude;
            IsVegetarian = isVegetarian;
            IsVegan = isVegan;
        }
    }
}

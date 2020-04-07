using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace gooche.Classes
{
    public class Menu
    {
        [Key]
        [DataMember]
        public int MenuId { get; set; }
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public string MenuName { get; set; }
        [DataMember]
        public DateTime ActiveFrom { get; set; }
        [DataMember]
        public DateTime ActiveTo { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public double Latitude { get; set; }
        [DataMember]
        public double Longitude { get; set; }
        [DataMember]
        public bool IsVegetarian { get; set; }
        [DataMember]
        public bool IsVegan { get; set; }

        public Menu(int userId, string menuName, DateTime activeFrom, DateTime activeTo, double price, double latitude, double longitude, bool isVegetarian = false, bool isVegan = false)
        {
            MenuId = 0; //generated
            UserId = userId;
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

using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace gooche.Classes
{
    public class UserData : LoginParameters
    {
        public int UserID { get; }

        public DateTime BirthDate { get; }

        public string Email { get; }

        public int Rating { get; }

        public UserData(string username, DateTime birthDate, string email, string password = null)
            : base(username, password)
        {
            BirthDate = birthDate;
            Email = email;
        }

        public UserData(int userId)
        {
            UserID = userId;
        }
    }
}

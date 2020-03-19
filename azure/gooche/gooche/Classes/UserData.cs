using System;
using System.Collections.Generic;
using System.Text;

namespace gooche.Classes
{
    public class UserData
    {
        public string UserName { get; }

        public DateTime BirthDate { get; }

        public int Rating { get; }

        public UserData(string userName, DateTime birthDate, int rating)
        {
            UserName = userName;
            BirthDate = birthDate;
            Rating = rating;
        }
    }
}

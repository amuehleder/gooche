using System;
using System.Collections.Generic;
using System.Text;

namespace gooche.Classes
{
    public class RegisterParameters : LoginParameters
    {
        public DateTime BirthDate { get; }

        public string Email { get; }

        public RegisterParameters(string userName, DateTime birthDate, string password, string email)
            : base(userName, password)
        {
            BirthDate = birthDate;
            Email = email;
        }
    }
}

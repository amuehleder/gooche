using System;
using System.Collections.Generic;
using System.Text;

namespace gooche.Classes
{
    public class LoginParameters
    {
        public string Username { get; }
        public string Password { get; }

        public LoginParameters(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public LoginParameters() { }
    }
}

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace gooche.Classes
{
    public class LoginParameters
    {
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Password { get; set; }

        public LoginParameters(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace gooche.Classes
{
    [DataContract(Namespace = "gooche.Domain")]
    public class UserData : LoginParameters
    {
        [Key]
        [DataMember]
        public int UserID { get; set; }

        [DataMember]
        public DateTime BirthDate { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public int Rating { get; set; }

        public UserData(string username, DateTime birthDate, int rating, string email, string password = null)
            : base(username, password)
        {
            UserID = 0; //generated
            BirthDate = birthDate;
            Rating = rating;
            Email = email;
        }
    }
}

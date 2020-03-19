using System;
using System.Collections.Generic;
using System.Text;

namespace gooche.Classes
{
    public class Menu
    {
        public UserData User { get; }
        public string MenuName { get; }
        public DateTime From { get; }
        public DateTime To { get; }

        public Menu(UserData user, string menuName, DateTime from, DateTime to)
        {
            User = user;
            MenuName = menuName;
            From = from;
            To = to;
        }
    }
}

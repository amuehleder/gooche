using gooche.Classes;
using gooche.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace gooche.Services
{
    public class AccountService : IAccountService
    {
        private bool isLoggedIn;

        private UserData userData;

        public UserData GetUserData()
        {
            if(isLoggedIn)
            {
                return userData;
            }
                return null;
        }

        public void StoreLoginUserData(UserData data)
        {
            isLoggedIn = true;
            userData = data;
        }
    }
}

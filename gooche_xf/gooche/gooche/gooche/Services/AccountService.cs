using gooche.Classes;
using gooche.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace gooche.Services
{
    public class AccountService : IAccountService
    {
        private bool isLoggedIn;

        private UserData userData;

        private Location userPosition;

        public Location GetCurrentUserPosition()
        {
            return userPosition;
        }

        public UserData GetUserData()
        {
            if(isLoggedIn)
            {
                return userData;
            }
            return null;
        }

        public bool GetUserLoggedIn()
        {
            return isLoggedIn;
        }

        public void SetCurrentUserPosition(Location currentLocation)
        {
            userPosition = currentLocation;
        }

        public void StoreLoginUserData(UserData data)
        {
            isLoggedIn = true;
            userData = data;
        }
    }
}

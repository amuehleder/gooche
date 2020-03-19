using gooche.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace gooche.Interfaces
{
    public interface IAccountService
    {
        void StoreLoginUserData(UserData userData);

        UserData GetUserData();

        Location GetCurrentUserPosition();

        void SetCurrentUserPosition(Location currentLocation);
    }
}

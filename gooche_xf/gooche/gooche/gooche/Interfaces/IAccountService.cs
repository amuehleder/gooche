using gooche.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace gooche.Interfaces
{
    public interface IAccountService
    {
        void StoreLoginUserData(UserData userData);

        UserData GetUserData();
    }
}

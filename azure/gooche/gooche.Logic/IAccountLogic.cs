using gooche.Classes;
using gooche.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace gooche.Logic
{
    public interface IAccountLogic
    {
        Task<ServiceResponse> LoginUserAsync(LoginParameters loginParams);
        Task<ServiceResponse> RegisterUserAsync(UserData user);
    }
}

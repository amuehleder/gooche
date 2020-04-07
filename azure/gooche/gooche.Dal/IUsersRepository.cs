using gooche.Classes;
using gooche.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace gooche.Dal
{
    public interface IUsersRepository
    {
        Task<ServiceResponse> LoginUserAsync(LoginParameters user);
        Task<ServiceResponse> RegisterUserAsync(UserData user);
    }
}

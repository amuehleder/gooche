using gooche.Classes;
using gooche.Dal;
using gooche.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace gooche.Logic
{
    public class AccountLogic : IAccountLogic
    {
        private IUsersRepository userRepo;

        public AccountLogic(IUsersRepository userRepo)
        {
            this.userRepo = userRepo;
        }

        public async Task<ServiceResponse> LoginUserAsync(LoginParameters loginParams)
        {
            Console.WriteLine($"Trying to login user {loginParams.Username}");
            return await userRepo.LoginUserAsync(loginParams);
        }

        public async Task<ServiceResponse> RegisterUserAsync(UserData user)
        {
            Console.WriteLine($"Insert User {user.Username}");
            return await userRepo.RegisterUserAsync(user);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using gooche.Classes;
using gooche.Domain.Classes;
using Microsoft.EntityFrameworkCore;


namespace gooche.Dal
{
    public class UsersRepository : IUsersRepository
    {
        private goocheContext context;

        public UsersRepository(goocheContext context)
        {
            this.context = context;
        }

        public async Task<ServiceResponse> LoginUserAsync(LoginParameters user)
        {
           var loginUser = await context.Users.FirstOrDefaultAsync(x => x.Email == user.Username || x.Username == user.Username);
            if(loginUser == null || loginUser.Password != user.Password)
            {
                return new ServiceResponse(Domain.Classes.Enum.Enums.ServiceResponseState.LoginFailed, null);
            }

            return new ServiceResponse(Domain.Classes.Enum.Enums.ServiceResponseState.Success, loginUser);
        }

        public async Task<ServiceResponse> RegisterUserAsync(UserData user)
        {
            var checkUser = await context.Users.FirstOrDefaultAsync(x => x.Username == user.Username || x.Email == user.Email);
            if(checkUser != null)
            {
                if(checkUser.Username == user.Username)
                {
                    return new ServiceResponse(Domain.Classes.Enum.Enums.ServiceResponseState.UsernameTaken, null);
                }

                if (checkUser.Email == user.Email)
                {
                    return new ServiceResponse(Domain.Classes.Enum.Enums.ServiceResponseState.AlreadyRegistered, null);
                }
            }
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
            return new ServiceResponse(Domain.Classes.Enum.Enums.ServiceResponseState.Success, user.UserID);
        }
    }
}

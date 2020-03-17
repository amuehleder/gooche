using gooche.Classes;
using gooche.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace gooche.Models
{
    public class LoginModel : ILoginModel
    {
        private IHttpService httpService { get; }
        private IAccountService accountService { get; }

        public LoginModel(IHttpService httpSvc, IAccountService accountSvc)
        {
            httpService = httpSvc;
            accountService = accountSvc;
        }

        public async Task<bool> Login(LoginParameters loginParams)
        {
            var response = await httpService.PostRequest("Login", loginParams);
            if(response.ResponseState == Classes.Enum.Enums.ServiceResponseState.Success)
            {
                accountService.StoreLoginUserData(JsonConvert.DeserializeObject<UserData>(response.ResponseContent.ToString()));
                return true;
            }
            return false;
        }
    }
}

using gooche.Classes;
using gooche.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace gooche.Models
{
    class RegisterModel : IRegisterModel
    {
        private IHttpService httpService { get; }
        private IAccountService accountService { get; }

        public RegisterModel(IHttpService httpSvc, IAccountService accountSvc)
        {
            httpService = httpSvc;
            accountService = accountSvc;
        }

        public async Task<bool> Register(UserData userData)
        {
            var response = await httpService.PostRequest("Register", userData);
            if (response.ResponseState == Classes.Enum.Enums.ServiceResponseState.Success)
            {
                return JsonConvert.DeserializeObject<bool>(response.ResponseContent.ToString());
            }
            return false;
        }
    }
}

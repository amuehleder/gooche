using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using gooche.Classes;
using AzureFunctions.Autofac;
using gooche.Dal;
using gooche.Dal;
using gooche.Logic;
using gooche.Function;
using gooche.Domain.Classes;

namespace gooche.Functions
{
    [DependencyInjectionConfig(typeof(AutofacStartup))]
    public class AccountFunctions
    {

        private readonly goocheContext _context;
        public AccountFunctions(goocheContext context)
        {
            _context = context;
        }

        [FunctionName("Login")]
        public static async Task<ServiceResponse> Login(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            [Inject] IAccountLogic logic,
            ILogger log)
        {
            log.LogInformation("Triggered Login");

            string requestBody = await req.ReadAsStringAsync();
            var loginData = JsonConvert.DeserializeObject<LoginParameters>(requestBody);

            return await logic.LoginUserAsync(loginData);
        }

        [FunctionName("Register")]
        public static async Task<ServiceResponse> Register(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            [Inject] IAccountLogic logic,
            ILogger log)
        {
            log.LogInformation("Triggered Registration");

            string requestBody = await req.ReadAsStringAsync();
            var registerData = JsonConvert.DeserializeObject<UserData>(requestBody);

            return await logic.RegisterUserAsync(registerData);
        }
    }
}

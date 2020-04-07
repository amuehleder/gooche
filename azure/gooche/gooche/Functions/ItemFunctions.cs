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
using System.Collections.Generic;
using AzureFunctions.Autofac;
using gooche.Function;
using gooche.Logic;
using gooche.Domain.Classes;

namespace gooche.Functions
{
    [DependencyInjectionConfig(typeof(AutofacStartup))]
    public static class ItemFunctions
    {
        [FunctionName("GetMenus")]
        public static async Task<ServiceResponse> GetMenus(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            var returnList = new List<Menu>();

            for(int i = 0; i < 5; i++)
            {
                returnList.Add(new Menu(3, "testmenu", DateTime.Now, DateTime.Now, 5, 5, 5));
            }

            return new ServiceResponse(Domain.Classes.Enum.Enums.ServiceResponseState.Success, returnList);
        }

        [FunctionName("CreateMenu")]
        public static async Task<ServiceResponse> CreateMenu(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            [Inject] IMenuLogic logic,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            string requestBody = await req.ReadAsStringAsync();
            var menuData = JsonConvert.DeserializeObject<Menu>(requestBody);

            return await logic.CreateMenuAsync(menuData);
        }
    }
}

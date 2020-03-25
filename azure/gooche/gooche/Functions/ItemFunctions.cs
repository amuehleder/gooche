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

namespace gooche.Functions
{
    public static class ItemFunctions
    {
        [FunctionName("GetMenus")]
        public static async Task<List<Menu>> GetMenus(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            var returnList = new List<Menu>();

            for(int i = 0; i < 5; i++)
            {
                returnList.Add(new Menu(new UserData("testuser", DateTime.Now, 3), "testmenu", DateTime.Now, DateTime.Now, 5, 5, 5));
            }

            return returnList;
        }
    }
}

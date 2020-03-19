using gooche.Classes;
using gooche.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace gooche.Models
{
    class ItemsModel : IItemsModel
    {
        private IHttpService httpService { get; }

        public ItemsModel(IHttpService httpSvc)
        {
            httpService = httpSvc;
        }

        public async Task<List<Menu>> GetMenus()
        {
            var response = await httpService.GetRequest("GetMenus");
            if (response.ResponseState == Classes.Enum.Enums.ServiceResponseState.Success)
            {
                return JsonConvert.DeserializeObject<List<Menu>>(response.ResponseContent.ToString());
            }
            return null;
        }
    }
}

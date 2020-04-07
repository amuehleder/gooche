using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using gooche.Classes;
using gooche.Domain.Classes;

namespace gooche.Dal
{
    public class MenuRepository : IMenuRepository
    {
        private goocheContext context;

        public MenuRepository(goocheContext context)
        {
            this.context = context;
        }

        public async Task<ServiceResponse> CreateMenuAsync(Menu menu)
        {
            await context.Menus.AddAsync(menu);
            await context.SaveChangesAsync();
            return new ServiceResponse(Domain.Classes.Enum.Enums.ServiceResponseState.Success, menu);
        }
    }
}

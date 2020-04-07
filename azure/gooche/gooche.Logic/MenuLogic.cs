using gooche.Classes;
using gooche.Dal;
using gooche.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace gooche.Logic
{
    public class MenuLogic : IMenuLogic
    {
        private IMenuRepository menuRepo;

        public MenuLogic(IMenuRepository menuRepo)
        {
            this.menuRepo = menuRepo;
        }

        public async Task<ServiceResponse> CreateMenuAsync(Menu menu)
        {
            Console.WriteLine($"Create Menu {menu.MenuName}");
            return await menuRepo.CreateMenuAsync(menu);
        }
    }
}

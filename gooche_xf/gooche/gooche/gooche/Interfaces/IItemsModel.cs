using gooche.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace gooche.Interfaces
{
    public interface IItemsModel
    {
        Task<List<Menu>> GetMenus();
    }
}

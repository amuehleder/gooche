using gooche.Classes;
using gooche.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace gooche.Logic
{
    public interface IMenuLogic
    {
        Task<ServiceResponse> CreateMenuAsync(Menu menu);
    }
}

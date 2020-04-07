using gooche.Classes;
using gooche.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace gooche.Dal
{
    public interface IMenuRepository
    {
        Task<ServiceResponse> CreateMenuAsync(Menu menu);
    }
}

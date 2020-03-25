using gooche.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace gooche.Interfaces
{
    public interface IRegisterModel
    {
        Task<bool> Register(RegisterParameters loginParams);
    }
}

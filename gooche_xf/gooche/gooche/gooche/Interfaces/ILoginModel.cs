using gooche.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace gooche.Interfaces
{
    public interface ILoginModel
    {
        Task<bool> Login(LoginParameters loginParams);
    }
}

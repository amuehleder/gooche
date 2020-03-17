using gooche.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace gooche.Interfaces
{
    public interface IHttpService
    {
        Task<ServiceResponse> GetRequest(string uri);

        Task<ServiceResponse> PostRequest(string uri, object content);
    }
}

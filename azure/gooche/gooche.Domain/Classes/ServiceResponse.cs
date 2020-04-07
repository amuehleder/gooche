using System;
using System.Collections.Generic;
using System.Text;
using static gooche.Domain.Classes.Enum.Enums;

namespace gooche.Domain.Classes
{
    public class ServiceResponse
    {
        public ServiceResponseState ResponseState { get; }
        public object ResponseContent { get; }

        public ServiceResponse(ServiceResponseState responseState, object content = null)
        {
            ResponseState = responseState;
            ResponseContent = content;
        }
    }
}

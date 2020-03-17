using System;
using System.Collections.Generic;
using System.Text;
using static gooche.Classes.Enum.Enums;

namespace gooche.Classes
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

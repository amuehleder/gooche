using System;
using System.Collections.Generic;
using System.Text;

namespace gooche.Domain.Classes.Enum
{
    public class Enums
    {
        public enum ServiceResponseState
        {
            Success,
            LoginFailed,
            UsernameTaken,
            AlreadyRegistered,
            Failure
        }
    }
}

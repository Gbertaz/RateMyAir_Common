using System;
using System.Globalization;

namespace RateMyAir.Common.Entities.Exceptions
{
    public class UnauthorizedException : Exception
    {
        public UnauthorizedException() : base("You are not authorized.") { }

        public UnauthorizedException(string message) : base(message) { }

        public UnauthorizedException(string message, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}

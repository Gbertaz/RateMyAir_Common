using System;

namespace RateMyAir.Common.Interfaces.Formatters
{
    public interface IDateFormatter
    {
        abstract string FormatDate(DateTime date);
    }
}

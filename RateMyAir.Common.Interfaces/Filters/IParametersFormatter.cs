using System;

namespace RateMyAir.Common.Interfaces.Filters
{
    public interface IParametersFormatter
    {
        protected static string FormatDate(DateTime date) => date.ToString("yyyy-MM-dd");
        public string CreateQueryStringParameters();
    }
}

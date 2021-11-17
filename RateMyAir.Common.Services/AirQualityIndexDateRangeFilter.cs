using RateMyAir.Common.Interfaces;
using System;

namespace RateMyAir.Common.Services
{
    public class AirQualityIndexDateRangeFilter : IAirQualityIndexEndpointProvider
    {
        private readonly DateTime _fromDate;
        private readonly DateTime _toDate;

        public AirQualityIndexDateRangeFilter(DateTime fromDate, DateTime toDate)
        {
            _fromDate = fromDate;
            _toDate = toDate;
        }

        public string CreateEndpoint(string baseEndpoint)
        {
            return string.Format("{0}?fromDate={1}&toDate={2}", baseEndpoint, _fromDate.ToString("yyyy-MM-dd"), _toDate.ToString("yyyy-MM-dd"));
        }
    }
}

using RateMyAir.Common.Interfaces;
using System;

namespace RateMyAir.Common.Services
{
    public class AirQualityIndexDateFromFilter : IAirQualityIndexEndpointProvider
    {
        private readonly DateTime _fromDate;

        public AirQualityIndexDateFromFilter(DateTime fromDate)
        {
            _fromDate = fromDate;
        }
        
        public string CreateEndpoint(string baseEndpoint)
        {
            return string.Format("{0}?fromDate={1}", baseEndpoint, _fromDate.ToString("yyyy-MM-dd"));
        }
    }
}

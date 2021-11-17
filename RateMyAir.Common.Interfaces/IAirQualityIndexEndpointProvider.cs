using System;

namespace RateMyAir.Common.Interfaces
{
    public interface IAirQualityIndexEndpointProvider
    {
        public string CreateEndpoint(string baseEndpoint);
    }
}

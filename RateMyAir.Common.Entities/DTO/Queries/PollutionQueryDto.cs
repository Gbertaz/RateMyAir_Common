﻿using System;

namespace RateMyAir.Common.Entities.DTO.Queries
{
    public class PollutionQueryDto
    {
        public double Pm25 { get; set; }
        public double Pm10 { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

﻿using MedTechApp.Application.Common.Interfaces;
using System;

namespace MedTechApp.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}

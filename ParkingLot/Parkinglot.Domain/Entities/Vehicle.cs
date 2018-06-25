using Parkinglot.Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parkinglot.Domain.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }

        public VehicleType Type { get; set; }

        public string Factory { get; set; }

        public string Color { get; set; }

        public int YearFactory { get; set; }
    }
}

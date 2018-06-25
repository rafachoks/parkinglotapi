using System;
using System.Collections.Generic;
using System.Text;

namespace Parkinglot.Domain.Entities
{
    public class Car : Vehicle
    {
        public string Name { get; set; }

        public string Model { get; set; }
    }
}

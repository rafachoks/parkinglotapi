using Parkinglot.Domain.Entities.Enum;

namespace Parkinglot.Application.Model.Vehicle
{
    public class VehicleModel
    {
        public virtual VehicleType Type { get; set; }

        public virtual string Factory { get; set; }

        public virtual string Color { get; set; }

        public virtual int YearFactory { get; set; }
    }
}

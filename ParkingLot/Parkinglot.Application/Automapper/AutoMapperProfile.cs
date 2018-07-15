using AutoMapper;
using Parkinglot.Application.Model.Vehicle;
using Parkinglot.Domain.Entities;

namespace Parkinglot.Application.Automapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Car, CarModel>().ReverseMap();
            CreateMap<Motocycle, MotocycleModel>().ReverseMap();
            CreateMap<Vehicle, VehicleModel>().ReverseMap();
        }
    }
}

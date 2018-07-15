using System;
using System.Collections.Generic;
using System.Text;
using Parkinglot.Data.Context;
using Parkinglot.Domain.Entities;
using Parkinglot.Domain.Interface;

namespace Parkinglot.Data.Repositories
{
    public class CarRepository : RepositoryBase<Car>, ICarRepository
    {
        public CarRepository(ParkinglotContext context) : base(context)
        {
        }
    }
}

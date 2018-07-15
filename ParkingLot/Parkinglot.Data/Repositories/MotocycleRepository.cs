using System;
using System.Collections.Generic;
using System.Text;
using Parkinglot.Data.Context;
using Parkinglot.Domain.Entities;
using Parkinglot.Domain.Interface;

namespace Parkinglot.Data.Repositories
{
    public class MotocycleRepository: RepositoryBase<Motocycle>, IMotocycleRepository
    {
        public MotocycleRepository(ParkinglotContext context) : base(context)
        {
        }
    }
}

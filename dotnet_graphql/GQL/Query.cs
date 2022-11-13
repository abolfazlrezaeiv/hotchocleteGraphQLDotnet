using System;
using API.Data;

namespace API
{
    public class Query
    {
        [UsePaging]
        public IQueryable<Car> GetCars(CarDbContext cars) => cars.cars;  
    }
}


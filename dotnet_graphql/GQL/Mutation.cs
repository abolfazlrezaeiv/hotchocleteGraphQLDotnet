using System;
using System.Runtime.ConstrainedExecution;
using API.Data;
using Microsoft.EntityFrameworkCore;

namespace API
{
    public class Mutation
    {
        public async Task<Car> AddCar(string name,CarDbContext context)
        {
            Car car = new Car(name: name);
            context.Add(car);
            await context.SaveChangesAsync();

            return car;
        }
    }
}


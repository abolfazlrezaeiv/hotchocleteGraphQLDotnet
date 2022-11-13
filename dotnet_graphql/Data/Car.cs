using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class Car
    {
        public Car(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
 
    }
}


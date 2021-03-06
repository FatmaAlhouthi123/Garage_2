﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Garage_2.Models;

namespace Garage_2.Data
{
    public class Garage_2Context : DbContext
    {
        public Garage_2Context(DbContextOptions<Garage_2Context> options)
            : base(options)
        {
        }

        public DbSet<ParkedVehicle> ParkedVehicle { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<VehicleType> VehicleType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //The seed entity for entity type 'ParkedVehicle' cannot be added because it has the navigation 'VehicleType' set. To seed relationships you need to add the related entity seed to 
            //'VehicleType' and spec
            // ify the foreign key values { 'VehicleTypeId'}. Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see the involved property values.
            /*
            modelBuilder.Entity<ParkedVehicle>().HasData(
                new ParkedVehicle
                {
                    Id = 1,
                    VehicleType = new VehicleType(),
                    RegisterNumber = "abc123",
                    Color = "Blue",
                    Model = "A1",
                    Brand = "Airbus",
                    WheelsNumber = 10,
                    ParkedDateTime = DateTime.Now.AddHours(-2).AddMinutes(-2)     // new DateTime(2018, 3, 1, 7, 0, 0),
                },

                new ParkedVehicle
                {
                    Id = 2,
                    VehicleType = new VehicleType(),
                    RegisterNumber = "dkl785",
                    Color = "Black",
                    Model = "B2",
                    Brand = "Volvo",
                    WheelsNumber = 4,
                    ParkedDateTime = DateTime.Now
                },

                new ParkedVehicle
                {
                    Id = 3,
                    VehicleType = new VehicleType(),
                    RegisterNumber = "uio159",
                    Color = "Red",
                    Model = "C3",
                    Brand = "Saga",
                    WheelsNumber = 0,
                    ParkedDateTime = DateTime.Now.AddMinutes(-3)
                });


            modelBuilder.Entity<VehicleType>().HasData(
                new VehicleType
                {
                    Id = 1,
                    VehicType = "Tractor"
                },

                new VehicleType
                {
                    Id = 2,
                    VehicType = "Tractor2"
                },

                new VehicleType
                {
                    Id = 3,
                    //VehicleType = new VehicleType().VehicType,
                    VehicType = "Tractor3"
                });
            */
        }
    }
}

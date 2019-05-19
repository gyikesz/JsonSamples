﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace JsonSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new[]
            {
                new Car
                {
                    PlateNumber = "NXS-489",
                    Owner = new Owner
                    {
                        FirstName = "Richárd",
                        LastName = "Gyikó"
                    }
                },
                new Car
                {
                    PlateNumber = "HGI-435",
                    Owner = new Owner
                    {
                        FirstName = "Péter",
                        LastName = "Molnár"
                    }
                }
            };


            var carsAsJson = JsonConvert.SerializeObject(cars, Formatting.Indented);

            Console.WriteLine(carsAsJson);

            var deserializedCars = JsonConvert.DeserializeObject<List<Car>>(carsAsJson);

            Console.ReadLine();
        }
    }
}

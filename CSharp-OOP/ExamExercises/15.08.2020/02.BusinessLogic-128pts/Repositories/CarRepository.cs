﻿using CarRacing.Models.Cars.Contracts;
using CarRacing.Repositories.Contracts;
using CarRacing.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRacing.Repositories
{
    public class CarRepository : IRepository<ICar>
    {
        private List<ICar> cars;
        public CarRepository()
        {
            this.cars = new List<ICar>();
        }
        public IReadOnlyCollection<ICar> Models
            => this.cars;
        
        public void Add(ICar model)
        {
            if (model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidAddCarRepository);
            }
            this.cars.Add(model);
        }

        public ICar FindBy(string property)
        {
            
            /*if (!(this.cars.Any(c => c.VIN == property)))
            {
                return null;
            }*/
            var carWithGivenVIN = this.cars.FirstOrDefault(c => c.VIN == property);
            return carWithGivenVIN;



        }

        public bool Remove(ICar model)
           => this.cars.Remove(model);
    }
}

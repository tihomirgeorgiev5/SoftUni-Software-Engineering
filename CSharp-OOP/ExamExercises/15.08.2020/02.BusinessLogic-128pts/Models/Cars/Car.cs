using CarRacing.Models.Cars.Contracts;
using CarRacing.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Cars
{
    public abstract class Car : ICar
    {
        string make;
        string model;
        string vin;
        int horsePower;
        double fuelAvailable;
        double fuelConsumtpionPerRace;

        public Car(string make, string model, string VIN, int horsePower, double fuelAvailable, double fuelConsumptionPerRace)
        {
            this.Make = make;
            this.Model = model;
            this.VIN = VIN;
            this.HorsePower = horsePower;
            this.FuelAvailable = fuelAvailable;
            this.FuelConsumptionPerRace = fuelConsumptionPerRace;
            

        }

        public string Make
        {
            get
            {
                return this.make;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarMake);
                }
                this.make = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarModel);
                }
                this.model = value;
            }
        }


        public string VIN
        {
            get
            {
                return this.vin;
            }
            set
            {
                if (value.Length != 17)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarVIN);
                }
                this.vin = value;
            }
        }


        public int HorsePower
        {
            get
            {
                return this.horsePower;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarHorsePower);
                }
                this.horsePower = value;
            }
        }


        public double FuelAvailable
        {
            get
            {
                return this.fuelAvailable;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                this.fuelAvailable = value;
            }
        }


        public double FuelConsumptionPerRace
        {
            get
            {
                return this.fuelConsumtpionPerRace;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarFuelConsumption);
                }
                this.fuelConsumtpionPerRace = value;
            }
        }


        public virtual void Drive()
        {
            this.fuelAvailable -= this.fuelConsumtpionPerRace;
        }
    }
}

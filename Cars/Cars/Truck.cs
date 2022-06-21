using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Truck : Car
    {
        private double loadCapacity;
        public Truck(VehicleType vehicleType, double averageFuelEconomy, double fuelTankVolume, double speed) : base(vehicleType, averageFuelEconomy, fuelTankVolume, speed)
        {
        }

        public double LoadCapacity { 
            get
            {
                return loadCapacity;
            }
            set
            {
                if (CheckLoadCapacity(value))
                {
                    loadCapacity = value;
                }
                else
                {
                    throw new Exception("Превышена грузоподъёмность");
                }
            }
        }

        private bool CheckLoadCapacity(double capacity)
        {
            return (capacity <= 15_000.0) ? true : false;
        }

        public override double GetPowerReserve()
        {
            double distance = GetReimainingDistance();
            return distance - distance * 0.04 * Math.Round(loadCapacity/200.0);
        }
    }
}

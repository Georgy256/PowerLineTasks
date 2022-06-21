using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    abstract class Car
    {
        private VehicleType vehicleType;
        private double averageFuelEconomy;
        private double fuelTankVolume;
        private double speed;

        public Car(VehicleType vehicleType, double averageFuelEconomy, double fuelTankVolume, double speed)
        {
            this.vehicleType = vehicleType;
            this.averageFuelEconomy = averageFuelEconomy;
            this.fuelTankVolume = fuelTankVolume;
            this.speed = speed;
        }

        public abstract double GetPowerReserve();

        public double GetReimainingDistance()
        {
            return Math.Round(fuelTankVolume / averageFuelEconomy)*100.0;
        }

        public double GetReimainingDistance(double currentFuelAmount)
        {
            return Math.Round(currentFuelAmount / averageFuelEconomy)*100.0;
        }

        public double GetDistanceTime(double distance, double currentFuelAmount)
        {
            if (GetReimainingDistance(currentFuelAmount) < distance)
            {
                throw new Exception("Количество топлива недостаточно");
            }
            return distance / speed;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class SportCar : Car
    {
        public SportCar(VehicleType vehicleType, double averageFuelEconomy, double fuelTankVolume, double speed) : base(vehicleType, averageFuelEconomy, fuelTankVolume, speed)
        {
        }

        public override double GetPowerReserve()
        {
            return GetReimainingDistance();
        }
    }
}

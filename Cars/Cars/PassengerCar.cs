using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class PassengerCar : Car
    {
        private double passengerAmount;

        public PassengerCar(VehicleType vehicleType, double averageFuelEconomy, double fuelTankVolume, double speed) : base(vehicleType, averageFuelEconomy, fuelTankVolume, speed)
        {
        }

        public double PassengerAmount { 
            get
            {
                return passengerAmount;
            } 
            set
            {
                if (CheckPassengerAmount(value))
                {
                    passengerAmount = value;
                }
                else
                {
                    throw new Exception("Количество пассажиров должно быть не больше 4");
                }
            }
        }

        private bool CheckPassengerAmount(double passengerAmount)
        {
            return (passengerAmount <= 4) ? true : false;
        }

        public override double GetPowerReserve()
        {
            double distance = GetReimainingDistance();
            return distance - distance * 0.06 * passengerAmount;
        }
    }
}

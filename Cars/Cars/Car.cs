using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    abstract class Car
    {
        // Тип ТС
        private VehicleType vehicleType;
        // Средний расхода топлива
        private double averageFuelEconomy;
        // Объем топливного бака
        private double fuelTankVolume;
        // Скорость
        private double speed;

        public Car(VehicleType vehicleType, double averageFuelEconomy, double fuelTankVolume, double speed)
        {
            this.vehicleType = vehicleType;
            this.averageFuelEconomy = averageFuelEconomy;
            this.fuelTankVolume = fuelTankVolume;
            this.speed = speed;
        }

        /// <summary>
        /// Возвращает текущую информацию о состоянии запаса хода
        /// </summary>
        /// <returns>Запас хода</returns>
        public abstract double GetPowerReserve();

        /// <summary>
        /// Возвращает расстояние, которую автомобиль может проехать на полном баке топлива
        /// </summary>
        /// <returns>Расстояние</returns>
        public double GetReimainingDistance()
        {
            return Math.Round(fuelTankVolume / averageFuelEconomy)*100.0;
        }

        /// <summary>
        /// Возвращает расстояние, которую автомобиль может проехать на текущем количестве топлива
        /// </summary>
        /// <param name="currentFuelAmount">Текущее количество топлива</param>
        /// <returns>Расстояние</returns>
        public double GetReimainingDistance(double currentFuelAmount)
        {
            return Math.Round(currentFuelAmount / averageFuelEconomy)*100.0;
        }

        /// <summary>
        /// Возвращает время, за которое автомобиль проедет заданное расстояние, 
        /// или ошибку в случае нехватки топлива
        /// </summary>
        /// <param name="distance">Заданное расстояние</param>
        /// <param name="currentFuelAmount">Количество топлива</param>
        /// <returns>Время</returns>
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

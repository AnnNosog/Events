using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Car
    {
        public event EventHandler MoveEnded;

        private const int MaxFuel = 60;
        private const double MaxOil = 5;

        public string Name { get; private set; }
        public double Fuel { get; private set; }
        public double OilLevel { get; private set; }
        public int TemperatureEngine { get; private set; }

        public Car(string name, double fuel, double oil)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Uncorrect name.");
            }

            if (fuel <= 0 || fuel > MaxFuel)
            {
                throw new ArgumentException("Uncorrect fuel.");
            }

            if (oil <= 0 || oil > MaxOil)
            {
                throw new ArgumentException("Uncorrect oil.");
            }

            Name = name;
            Fuel = Math.Round(fuel, 2);
            OilLevel = Math.Round(oil, 2);
            TemperatureEngine = 0;

            MoveEnded += OnMoveEnded;
        }

        public void Move()
        {
            int distance = 0;

            while (true)
            {
                distance += 50;
                Fuel -= 5;

                if (Fuel <= 0)
                {
                    MoveEnded?.Invoke(this, new CarEventArgs("Закончилось топливо.", distance));
                    break;
                }

                OilLevel -= 0.1;

                if (OilLevel <= 0.6)
                {

                    MoveEnded?.Invoke(this, new CarEventArgs("Низкий уровень масла.", distance));
                    break;
                }

                TemperatureEngine += 15;

                if (TemperatureEngine > 100)
                {
                    MoveEnded?.Invoke(this, new CarEventArgs("Перегрев двигателя.", distance));
                    break;
                }

                MoveEnded?.Invoke(this, new CarEventArgs("Едем.", distance));

                Console.WriteLine();
            }
        }

        protected virtual void OnMoveEnded(object obj, EventArgs cer)
        {
            CarEventArgs carEventArgs = cer as CarEventArgs;

            Console.Write($"Сосстояние машины: {carEventArgs.Message}\t");
            Console.Write($"Проехали: {carEventArgs.Distance}");
        }
    }
}

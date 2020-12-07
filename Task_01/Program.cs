using System;
using CarLibrary;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW", 35, 3.0);
            car1.Move();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();

            var truck = new Truck();

            var vehicles = new List<IVehicle>() { car, truck };

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year} Make: {vehicle.Make} Model: {vehicle.Model}");
                Console.WriteLine();
                vehicle.Drive();
                vehicle.ChangeGears(true);
                vehicle.Reverse();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

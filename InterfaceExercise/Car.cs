using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        private bool isChanged;

        public Car()
        {
        }

        public double EngineSize { get; set; } = 5.0;
        public string Make { get; set; } = "Mercedez";
        public string Model { get; set; } = "C Class";
        public int Year { get; set; } = 2023;
        public int SeatCount { get; set; } = 3;
        public string CompanyName { get; set; } = "Mercedez";
        public string Motto { get; set; } = "Built strong and reliable";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward . . .");
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing . . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park . . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears");
            }
        }

        public void ChangedGears(bool hasChanged)
        {
            HasChangedGears = isChanged;
        }

        public void ChangeGears(bool isChnaged)
        {
            return;
        }

        public void DriveDefault()
        {
            return;
        }
    }
}


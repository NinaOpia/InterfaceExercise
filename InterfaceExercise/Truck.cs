using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
        private bool isChanged;

        public Truck()
		{
		}

        public double EngineSize { get; set; } = 6;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "F150";
        public int Year { get; set; } = 2021;
        public int SeatCount { get; set; } = 3;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built strong and reliable";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; } = true;
        

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4-Wheel drive {GetType().Name} now driving forward . . .");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} now driving forward . . .");
            }
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


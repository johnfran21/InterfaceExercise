using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public bool isPickup { get; set; }

        public string GasType { get; set; }

        //IVehicle
        public int NumberOfWheels { get; set; }
        public int NumberOfWindows { get; set; }
        public bool HasTrunk { get; set; }
        public string EngineType { get; set; }

        //ICompany
        public string Logo { get; set; }

        public int BestSalesYear { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"It is a Pickup Truck: {isPickup}");
            Console.WriteLine($"Company Logo: {Logo}");
            Console.WriteLine($"Best Sales of the Year in: {BestSalesYear}");
            Console.WriteLine($"Number of Wheels in Car: {NumberOfWheels}");
            Console.WriteLine($"Number of Windows in Car: {NumberOfWindows}");
            Console.WriteLine($"Car has a Trunk: {HasTrunk}");
            Console.WriteLine($"Car has a {EngineType} Engine Type");
        }
    }
}


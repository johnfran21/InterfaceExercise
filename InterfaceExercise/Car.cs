using System;
namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public string CarType { get; set; }

        public int NumberOfSeats { get; set; }


        //ICompany
        public string Logo { get; set; }

        public int BestSalesYear { get; set; }

        //IVehicle
        public int NumberOfWheels { get; set; }
        public int NumberOfWindows { get; set; }
        public bool HasTrunk { get; set; }
        public string EngineType { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Car Type: {CarType}");
            Console.WriteLine($"Number of Seats in Car: {NumberOfSeats}");
            Console.WriteLine($"Company Logo: {Logo}");
            Console.WriteLine($"Best Sales of the Year in: {BestSalesYear}");
            Console.WriteLine($"Number of Wheels in Car: {NumberOfWheels}");
            Console.WriteLine($"Number of Windows in Car: {NumberOfWindows}");
            Console.WriteLine($"Car has a Trunk: {HasTrunk}");
            Console.WriteLine($"Car has a {EngineType} Engine Type");

        }
    }
}


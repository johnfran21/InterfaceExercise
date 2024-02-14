using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public bool HasSunroof { get; set; }

        public string WeatherType { get; set; }

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
            Console.WriteLine($"It is a SUV");
            Console.WriteLine($"Does it have a Sunroof: {HasSunroof}");
            Console.WriteLine($"The Weather Type is: {WeatherType}");
            Console.WriteLine($"Company Logo: {Logo}");
            Console.WriteLine($"Best Sales of the Year in: {BestSalesYear}");
            Console.WriteLine($"Number of Wheels in Car: {NumberOfWheels}");
            Console.WriteLine($"Number of Windows in Car: {NumberOfWindows}");
            Console.WriteLine($"Car has a Trunk: {HasTrunk}");
            Console.WriteLine($"Car has a {EngineType} Engine Type");
        }
    }
}


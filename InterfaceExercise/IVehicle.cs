using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfWheels { get; set; }

        public int NumberOfWindows { get; set; }

        public bool HasTrunk { get; set; }

        public string EngineType { get; set; }

        public void DisplayDetails();


    }
}


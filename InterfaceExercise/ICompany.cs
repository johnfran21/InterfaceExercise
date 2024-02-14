using System;
namespace InterfaceExercise
{
    public interface ICompany
    {
        public string Logo { get; set; }

        public int BestSalesYear { get; set; }

        public void DisplayDetails();
    }
}


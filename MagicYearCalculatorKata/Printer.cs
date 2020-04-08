using System;
namespace MagicYearCalculatorKata
{
    public class Printer
    {
        public Printer()
        {
        }

        public void PrintReport(string firstName, string lastName, decimal monthlySalary, int magicYear)
        {
            Console.WriteLine("Your magic age details are:");
            Console.WriteLine($"Name:{firstName} {lastName}");
            Console.WriteLine($"Monthly Salary:{monthlySalary}");
            Console.WriteLine($"Magic Year: {magicYear}");


        }

    }
}

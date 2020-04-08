using System;
namespace MagicYearCalculatorKata
{
    public class Calculator
    {

        public decimal CalculateMonthlySalary(decimal annualSalary)
        {

            decimal monthlySalary = annualSalary / 12;
            return Math.Round(monthlySalary, 0, MidpointRounding.AwayFromZero);

        }

        public int CalculateMagicYear(int startYear)
        {
            int yearsToWork = 65;
            return startYear + yearsToWork;
        }

    }
}






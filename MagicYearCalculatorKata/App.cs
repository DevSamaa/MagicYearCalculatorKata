using System;
namespace MagicYearCalculatorKata
{
    public class App
    {
        public static decimal AnnualSalaryCalculator(decimal salaryInput) {
            decimal salaryCalculated = (salaryInput) / 12;
            return salaryCalculated;
        }

        public static int MagicyearCalculator(int yearInput)
        {
            int yearCalculated = yearInput + 65;
            return yearCalculated;
        }
       
    }
}

using System;
namespace MagicYearCalculatorKata
{
    public class InputValidator
    {
        public InputValidator()
        {
        }

        public decimal GetValidatedAnnualSalary(UserPrompt incomingUserPrompt)
        {
            bool isDecimal = false;
            decimal annualSalary = 0;

            while (isDecimal == false)
            {
                isDecimal = decimal.TryParse(incomingUserPrompt.GetAnnualSalary(), out annualSalary);

            }
            return annualSalary;

        }


        public int GetValidatedStartYear(UserPrompt incomingUserPrompt)
        {
            bool isInt = false;
            int startYear = 0;

            while (isInt == false)
            {
                isInt = int.TryParse(incomingUserPrompt.GetStartYear(), out startYear);

            }

            return startYear;

        }
    }
}

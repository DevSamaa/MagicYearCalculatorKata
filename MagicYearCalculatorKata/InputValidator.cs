using System;
namespace MagicYearCalculatorKata
{
    public class InputValidator
    {
        public InputValidator()
        {
        }

        public bool ValidateAnnualSalary(string incomingUserPrompt, out decimal outAnnualSalary)
        {
          
                bool isDecimal = decimal.TryParse(incomingUserPrompt, out var annualSalary);
                outAnnualSalary = annualSalary;
                return isDecimal;
        }


        public bool ValidateStartYear(string incomingUserPrompt, out int outStartYear)
        {
            bool isInt = int.TryParse(incomingUserPrompt, out var startYear);
            outStartYear = startYear;
            return isInt;

        }
    }
}

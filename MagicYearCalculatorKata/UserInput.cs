using System;
namespace MagicYearCalculatorKata
{
    public class UserInput
    {
        public UserInput()
        {
        }

        //get user name
        
        public decimal GetValidatedAnnualSalary()
        {
            while (true)
            {
                var userPrompt = new UserPrompt();
                var annualSalaryString = userPrompt.GetAnnualSalary();

                var inputValidator = new InputValidator();
                decimal annualSalaryDecimal;
                var isAnnualSalary = inputValidator.ValidateAnnualSalary(annualSalaryString, out annualSalaryDecimal);

                if (isAnnualSalary)
                {
                    return annualSalaryDecimal;
                }
                continue;
            }


        }


        public int GetValidatedStartYear()
        {
            while (true)
            {
                var userPrompt = new UserPrompt();
                var startYearString = userPrompt.GetStartYear();

                var inputValidator = new InputValidator();
                int startYearInt;
                var isStartYear = inputValidator.ValidateStartYear(startYearString, out startYearInt);

                if (isStartYear)
                {
                    return startYearInt;
                }


            }

        }
    }
}

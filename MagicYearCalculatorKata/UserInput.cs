using System;
namespace MagicYearCalculatorKata
{
    public class UserInput
    {
        UserPrompt userPrompt;
        InputValidator inputValidator;

        public UserInput()
        {
             userPrompt = new UserPrompt();
             inputValidator = new InputValidator();
        }


        public UserInputData GetUserInputData()
        {
            var firstName = userPrompt.GetUserName("first");
            var lastName = userPrompt.GetUserName("last");

            var checkedSalary = GetValidatedAnnualSalary();
            var checkedStartYear = GetValidatedStartYear();

           var instanceOfUserInputData= new UserInputData(){
                firstName = firstName,
                lastName = lastName,
                annualSalary = checkedSalary,
                startYear = checkedStartYear
            };
            return instanceOfUserInputData;
        }

        private decimal GetValidatedAnnualSalary()
        {
            while (true)
            {
                var annualSalaryString = userPrompt.GetAnnualSalary();

                decimal annualSalaryDecimal;
                var isAnnualSalary = inputValidator.ValidateAnnualSalary(annualSalaryString, out annualSalaryDecimal);

                if (isAnnualSalary)
                {
                    return annualSalaryDecimal;
                }
                continue;
            }


        }


        private int GetValidatedStartYear()
        {
            while (true)
            {
                var startYearString = userPrompt.GetStartYear();

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

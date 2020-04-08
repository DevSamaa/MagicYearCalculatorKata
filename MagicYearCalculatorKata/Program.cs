using System;

namespace MagicYearCalculatorKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the magic year calculator!");
            var instanceOfUserPrompt = new UserPrompt();
            var instanceOfInputValidator = new InputValidator();
            var instanceOfUserCalculator = new Calculator();

            var firstName = instanceOfUserPrompt.GetUserName("first");
            var lastName = instanceOfUserPrompt.GetUserName("last");

            //change this to reflect the new UserInput and Validator class
            var checkedSalary = instanceOfInputValidator.GetValidatedAnnualSalary(instanceOfUserPrompt);
            var checkedStartYear = instanceOfInputValidator.GetValidatedStartYear(instanceOfUserPrompt);

            var monthlySalary = instanceOfUserCalculator.CalculateMonthlySalary(checkedSalary);
            var magicyear = instanceOfUserCalculator.CalculateMagicYear(checkedStartYear);

            var instanceOfPrinter = new Printer();
            instanceOfPrinter.PrintReport(firstName, lastName, monthlySalary, magicyear);
        }
    }
}


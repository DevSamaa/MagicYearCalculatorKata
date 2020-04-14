using System;

namespace MagicYearCalculatorKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the magic year calculator!");

            var userInput = new UserInput();

            var instanceOfUserPrompt = new UserPrompt();
            var instanceOfUserCalculator = new Calculator();

            //this can probably also go in the input class
            var firstName = instanceOfUserPrompt.GetUserName("first");
            var lastName = instanceOfUserPrompt.GetUserName("last");


            var checkedSalary = userInput.GetValidatedAnnualSalary();
            var checkedStartYear = userInput.GetValidatedStartYear();

            var monthlySalary = instanceOfUserCalculator.CalculateMonthlySalary(checkedSalary);
            var magicyear = instanceOfUserCalculator.CalculateMagicYear(checkedStartYear);

            var instanceOfPrinter = new Printer();
            instanceOfPrinter.PrintReport(firstName, lastName, monthlySalary, magicyear);
        }
    }
}


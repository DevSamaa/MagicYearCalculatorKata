using System;

namespace MagicYearCalculatorKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the magic year calculator!");

            //get input
            var userInput = new UserInput();
            var inputData = userInput.GetUserInputData();

            //caluate
            var instanceOfUserCalculator = new Calculator();
            var monthlySalary = instanceOfUserCalculator.CalculateMonthlySalary(inputData.annualSalary);
            var magicyear = instanceOfUserCalculator.CalculateMagicYear(inputData.startYear);

            //output
            var instanceOfPrinter = new Printer();
            instanceOfPrinter.PrintReport(inputData.firstName, inputData.lastName, monthlySalary, magicyear);
        }
    }
}


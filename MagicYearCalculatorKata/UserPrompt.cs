using System;
namespace MagicYearCalculatorKata
{
    public class UserPrompt 
    {
        public UserPrompt()
        {
            
        }

        public string GetUserName(string FirstOrLast)
        {
            Console.WriteLine($"Please input your {FirstOrLast} name:");
            return Console.ReadLine();
        }


        public string GetAnnualSalary( )
        {
            Console.WriteLine("Please enter your annual salary:");
            return Console.ReadLine();
        }


        public string GetStartYear()
        {
            Console.WriteLine("Please enter your work start year:");
            return Console.ReadLine();
        }
    }
}

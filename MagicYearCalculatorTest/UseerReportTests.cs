using System;
using Xunit;
using MagicYearCalculatorKata;


namespace MagicYearCalculatorTest
{
    public class UserReportTests
    {

        [Theory]
        [InlineData(1980,2045)]
        [InlineData(2000,2065)]

        public void CalculateMagicYear_GivenNumber_ShouldReturnNumberPlus65(int startYear, int expected)
        {
            var instanceOfUserReport = new UserReport();
            var result = instanceOfUserReport.CalculateMagicYear(startYear);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(60000, 5000)]
        [InlineData(12000, 1000)]
        [InlineData(60050, 5004)]
        [InlineData(18,2)]

        public void CalculateMonthlySalary_GivenNumber_ShouldReturnNumberDividedBy12(int yearlySalary, int expected)
        {
            var instanceOfUserReport = new UserReport();
            var result = instanceOfUserReport.CalculateMonthlySalary(yearlySalary);

            Assert.Equal(expected, result);
        }
    }
}



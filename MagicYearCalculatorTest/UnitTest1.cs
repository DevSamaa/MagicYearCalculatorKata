using System;
using Xunit;
using MagicYearCalculatorKata;


namespace MagicYearCalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            decimal actualResult1 = App.AnnualSalaryCalculator(24);
            Assert.Equal(2 , actualResult1);

            decimal actualResult2 = App.AnnualSalaryCalculator(40000.80m);
            Assert.Equal(3333.40m, actualResult2);

        }
        [Fact]
        public void Test2()
        {
            int actualResult1 = App.MagicyearCalculator(2000);
            Assert.Equal(2065, actualResult1);
        }
    }
}

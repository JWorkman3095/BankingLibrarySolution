using AccountFormatLibrary;
using System;
using Xunit;

namespace TestInterestCalculation {
    public class UnitTest1 {

        [Theory]
        [InlineData(0, 36, 0.12, 100)]
        public void TestCalcIntByMonth(decimal interestAmount, int months, decimal interestRate, decimal balance) {
            Assert.Equal(interestAmount,
                FormatAccount.CalculateInterestByMonth(months, interestRate, balance));
        }
    }
}

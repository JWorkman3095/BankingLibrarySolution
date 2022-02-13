using System;


namespace AccountFormatLibrary {

    public class FormatAccount {

        public static decimal CalculateInterestByMonth(int months, decimal interestRate, decimal balance) {
            return balance * (interestRate / 12) * months;
        }
    }
}

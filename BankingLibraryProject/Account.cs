using System;

namespace BankingLibraryProject {
    public class Account {
        
        public decimal interestAmount;

        public int AccountNumber { get; set; } = 1;
        public string Description { get; set; } = "Interest - bearing account";
        public decimal Balance { get; set; } = 100;
        public decimal InterestRate { get; set; } = 0.12m;

        public decimal CalculateInterest(int months) {
            decimal interstAmount
                = AccountFormatLibrary.FormatAccount.CalculateInterestByMonth(months, InterestRate, Balance);
            Balance += interestAmount;
            return interestAmount;

        }


    }
}

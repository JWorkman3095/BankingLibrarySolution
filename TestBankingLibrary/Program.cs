using BankingLibraryProject;
using System;

namespace TestBankingLibrary {
    class Program {

        static void Main(string[] args) {

            Account account = new Account();
            account.CalculateInterest(12);
            Console.WriteLine(account.Balance);



        }
    }
}

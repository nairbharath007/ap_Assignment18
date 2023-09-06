using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountAppClassLibraryFramework
{
    [Serializable]
    public class Account
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public string BankName { get; set; }
        public double Balance { get; set; }

        public const double MIN_BALANCE = 500;
        public Account(int accountNumber, string accountHolderName, string bankName, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            BankName = bankName;
            Balance = balance;
        }
    }
}

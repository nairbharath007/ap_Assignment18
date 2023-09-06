using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountAppClassLibraryFramework.Service
{
    public class AccountManager
    {
        //public static string FilePath = ConfigurationManager.AppSettings["AccountDataFilePath"];
        public const string FilePath = "C:\\Users\\acer\\Desktop\\Aurionpro\\Training\\Assignments\\18\\AccountAppClassLibraryFramework\\accountDetails.txt";

        public static void SaveAccount(Account account)
        {
            DataSerialization.BinarySerialize(FilePath, account);
        }

        public static Account LoadAccount()
        {
            return DataSerialization.BinaryDeserialize(FilePath);
        }

        public static void Deposit(Account account, double amount)
        {
            if (amount > 0)
                account.Balance += amount;
        }

        public static void Withdraw(Account account, double amount)
        {
            double minBalance = 500;
            double potentialBalance = account.Balance - amount;

            if (potentialBalance >= minBalance)
            {
                account.Balance = potentialBalance;
            }
            else
            {
                throw new InsufficientBalanceException($"Insufficient Balance. A minimum amount of {Account.MIN_BALANCE} should be maintained");
            }
        }

        public static double CheckBalance(Account account)
        {
            return account.Balance;
        }
    }
}

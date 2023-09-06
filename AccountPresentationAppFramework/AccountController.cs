using AccountAppClassLibraryFramework;
using AccountAppClassLibraryFramework.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AccountPresentationAppFramework
{
    internal class AccountController
    {
        private AccountManager manager;

        public AccountController()
        {
            manager = new AccountManager();
        }

        public void Start()
        {
            Account account = AccountManager.LoadAccount();

            if (account == null)
            {
                Console.WriteLine("Welcome to the Account Application!");
                CreateAccount();
            }
            else
            {
                Console.WriteLine($"Welcome, {account.AccountHolderName}!");
                Console.WriteLine($"Account Balance: {account.Balance}");
            }

            while (true)
            {
                PrintMenu();
                int choice = GetUserChoice();

                switch (choice)
                {
                    case 1:
                        DepositMoney(account);
                        break;
                    case 2:
                        WithdrawMoney(account);
                        break;
                    case 3:
                        DisplayBalance(account);
                        break;
                    case 4:
                        Console.WriteLine("Exiting the application.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void CreateAccount()
        {
            Console.Write("Enter your Account Number: ");
            int accountNumber;
            while (!int.TryParse(Console.ReadLine(), out accountNumber))
            {
                Console.WriteLine("Invalid Account Number. Please enter a valid number.");
            }

            Console.Write("Enter your Account Holder Name: ");
            string accountHolderName = Console.ReadLine();

            Console.Write("Enter your Bank Name: ");
            string bankName = Console.ReadLine();

            double openingBalance;
            do
            {
                Console.Write("Enter Opening Balance (minimum 500 rupees): ");
            } while (!double.TryParse(Console.ReadLine(), out openingBalance) || openingBalance < 500);

            Account account = new Account(accountNumber, accountHolderName, bankName, openingBalance);
            AccountManager.SaveAccount(account);

            Console.WriteLine("Account created successfully!");
        }

        private void PrintMenu()
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Display Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
        }

        private int GetUserChoice()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice. Please enter a valid number.");
            }
            return choice;
        }

        private void DepositMoney(Account account)
        {
            Console.Write("Enter deposit amount: ");
            if (double.TryParse(Console.ReadLine(), out double depositAmount))
            {
                AccountManager.Deposit(account, depositAmount);
                AccountManager.SaveAccount(account);
                Console.WriteLine($"Deposited {depositAmount} rupees.");
            }
            else
            {
                Console.WriteLine("Invalid amount entered.");
            }
        }

        private void WithdrawMoney(Account account)
        {
            Console.Write("Enter withdrawal amount: ");
            if (double.TryParse(Console.ReadLine(), out double withdrawalAmount))
            {
                try
                {
                    AccountManager.Withdraw(account, withdrawalAmount);
                    AccountManager.SaveAccount(account);
                    Console.WriteLine($"Withdrawn {withdrawalAmount} rupees.");
                }
                catch (InsufficientBalanceException ibe)
                {
                    Console.WriteLine(ibe.Message);
                }
            }
            else
            {
                Console.WriteLine("Invalid amount entered.");
            }
        }

        private void DisplayBalance(Account account)
        {
            Console.WriteLine($"Account balance: {AccountManager.CheckBalance(account)} rupees.");
        }
    }
}


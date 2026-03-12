using System;

namespace ATM
{
    internal class Program
    {
        class ATM
        {
            public double balance;

            public ATM(double input_balance)
            {
                balance = input_balance;
            }

            public void depositMethod(double depositMoney)
            {
                Console.WriteLine("Deposit Method");
                balance += depositMoney;
                Console.WriteLine($"Total balance Calculated: {balance}");
            }

            public void withDraw(double withdrawMoney)
            {
                Console.WriteLine("Withdraw Method");
                balance -= withdrawMoney;
                Console.WriteLine($"Total balance: {balance}");
            }

            public void checkBalance()
            {
                Console.WriteLine("Balance Check Method");
                Console.WriteLine($"Balance is: {balance}");
            }

            public void transactionHistory(double[] history)
            {
                Console.WriteLine("Transaction History Method");
                Console.WriteLine($"Total Deposited Amount: {history[0]}");
                Console.WriteLine($"Total Withdrawn Amount: {history[1]}");
            }
        }

        static void Main(string[] args)
        {
            double[] history = new double[2];
            int choice;
            double depositAmount;
            double withdrawAmount;

            Console.WriteLine("Enter your balance:");
            double balance = double.Parse(Console.ReadLine());

            ATM a1 = new ATM(balance);

            do
            {
                Console.WriteLine("\nEnter your choice:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check balance");
                Console.WriteLine("4. Transaction history");
                Console.WriteLine("5. Exit Program");

                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Enter deposit amount:");
                    depositAmount = double.Parse(Console.ReadLine());

                    history[0] += depositAmount;
                    a1.depositMethod(depositAmount);
                }

                else if (choice == 2)
                {
                    Console.WriteLine("Enter withdraw amount:");
                    withdrawAmount = double.Parse(Console.ReadLine());

                    if (withdrawAmount <= a1.balance)
                    {
                        history[1] += withdrawAmount;
                        a1.withDraw(withdrawAmount);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Balance!");
                    }
                }

                else if (choice == 3)
                {
                    a1.checkBalance();
                }

                else if (choice == 4)
                {
                    a1.transactionHistory(history);
                }

            } while (choice != 5);
        }
    }
}
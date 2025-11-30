using System;
using System.Text.RegularExpressions;
using System.Transactions;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace ATM_Machine
{
    public delegate void TransactionHandler(string tansId);
    internal class Program
    {
        TransactionHandler transactionHandler ;
        public class updateBalance
        {
            public void UpdateBalance(string transId)
            {
                Console.WriteLine($"Updated Balance : {transId} payment updated.");
                transactionHandler!.Invoke(transId);
            }

        }
        


        public void SendNoti(string transId)
        {
            Console.WriteLine($"Notification Sent : {transId} payment successfuly updated.");
        }


        public void Logger(string transId)
        {
            Console.WriteLine($"Log : {transId} payment successfuly updated.");
        }


        static void Main(string[] args)
        {
            var updatebal = new UpdateBalance();

            for (int i = 0; i < 100; i++)
            {
                Console.Write("Enter pin of 4-digits : ");
                string userInput = Console.ReadLine();
                int Balance = 1000;
                int withdrawl;


                while (i < 100)
                {

                    if (Regex.IsMatch(userInput, @"^[0-9]{4}$"))
                    {
                        Console.Write("\nSelect option : ");
                        Console.WriteLine("1 : Cash Deposit    2 : Cash Withdrawl    3 : Balance Inquiry    4 : Account Transaction    5 : Account Switch    6 : Exit");

                        int userChoice = int.Parse(Console.ReadLine());
                        int deposit;

                        string accountTransaction;
                        int NetBalance = 0;

                        if (userChoice == 1)
                        {
                            //Console.Write("\nEnter your deposit amount : ");
                            //tt[i] = int.Parse(Console.ReadLine());
                            Console.WriteLine("\nEnter your deposit amount: ");
                            int userDeposit = int.Parse(Console.ReadLine());

                            Console.WriteLine("PKR {0} Cash Deposited Successfully", userDeposit);
                            Balance = Balance + userDeposit;


                        }
                        else if (userChoice == 2)
                        {
                            //Console.WriteLine("\nEnter your withdrawl amount : ");
                            //tt[i] = int.Parse(Console.ReadLine());
                            Console.Write("Enter Cash Withdrawl amount: ");
                            int userWithdrawl = int.Parse(Console.ReadLine());
                            Console.WriteLine("PKR {0} Cash Withdrawl Successfully", userWithdrawl);
                            Balance = Balance - userWithdrawl;
                            //withdrawl = Balance;
                        }
                        else if (userChoice == 3)
                        {
                            Console.WriteLine("\nBalance Inquiry: ");
                            Console.WriteLine("Your Total Balance is : PKR {0}", Balance);
                        }
                        else if (userChoice == 4)
                        {
                            Console.WriteLine("Account Transaction");
                        }
                        else if (userChoice == 5)
                        {

                            Console.WriteLine("Account Switching");

                        }
                        else if (userChoice == 6)
                        {
                            Console.WriteLine("Exit Successfull");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You entered invalid choice");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                        break;
                    }

                    i++;
                }
                continue;
            }


        }
    }
}

using System.Security.Cryptography.X509Certificates;

namespace ExceptionDev2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int balance = 3000;
                Console.WriteLine("Your Balance is {0}", balance);


                Console.Write("Enter Deposit Balance : ");

                bool isDepositSuccess = int.TryParse(Console.ReadLine(), out int Deposit);

                if (isDepositSuccess)
                {
                    if (Deposit <= 50000)
                    {
                        balance += Deposit;
                        Console.WriteLine("Your New Balance is {0}", balance);
                    }
                    else
                    {
                        Console.WriteLine("\nYour Deposit Limit is 50000.");
                    }


                    Console.Write("Enter Withdraw Balance : ");

                    bool isWithdrawlSucces = int.TryParse(Console.ReadLine(), out int Withdrawl);

                    if (isWithdrawlSucces)
                    {
                        if (Withdrawl <= 25000)
                        {
                            balance -= Withdrawl;
                            Console.WriteLine("Your New Balance is {0}", balance);
                        }
                        else
                        {
                            Console.WriteLine("\nYour Withdrawl Limit is 25000.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your Withdrawl Limit is 25000");
                    }
                }
                else
                {
                    Console.WriteLine("only numbers are allowed to enter!");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

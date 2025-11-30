using System.Reflection.Metadata;

namespace Enums4
{
    public enum BankAccountType
    {
        Saving =1,
        Current,
        Business
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = 100000;
            int interest = 15;
            Console.WriteLine("Enter Account Type to check interest rate : 1 : Saving   2 : Current   3 : Business");
            int value = int.Parse(Console.ReadLine());
            if (value == (int)BankAccountType.Saving)
            {
                Console.WriteLine($"You Account Limit is Per Day Transaction = {limit}");
                Console.WriteLine($"Interest Rate (%/month) = {interest}%");
            }
            else if (value == (int)BankAccountType.Current)
            {
                limit = 150000;
                interest = 10;
                Console.WriteLine($"You Account Limit is Per Day Transaction = {limit}");
                Console.WriteLine($"Interest Rate (%/month) = {interest}%");
            }
            else if (value == (int)BankAccountType.Business)
            {
                limit = 12000000;
                interest = 5;
                Console.WriteLine($"You Account Limit is Per Day Transaction = {limit}");
                Console.WriteLine($"Interest Rate (%/month) = {interest}%");
            }
            else
            {
                Console.WriteLine("You entered invalid account type!!!");
            }

        }
    }
}

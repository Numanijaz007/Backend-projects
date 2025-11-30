using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaceDev
{
    public class UserAccount
    {

        private int balance=0;

        public void Desposit(int amount)
        {
            balance += amount;
            Console.WriteLine("Amount credited:"+amount);
        }

        public void WithDraw(int amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient Balance.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Amount debited:" + amount);
            }
           
        }

        public int GetBalance()
        {
            return balance;
        }


    }


    public static class Util
    {

        public static void PrintSeperator()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
        }


    }
}

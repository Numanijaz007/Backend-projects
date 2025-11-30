using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Khata
{
    public class KhataManagement
    {
        
        private int TotalLoanBal = 0;
        public void LoanAmount(int amt)
        {

            if (amt > 10000)
            {
                Console.WriteLine("You can not take more loan!");

            }
            else
            {
                TotalLoanBal += amt;
                Console.WriteLine("Loan Recieved amount is : " + amt);
            }
        }

        public int GetLoanBalance()
        {
            return TotalLoanBal;
        }
        

    }

    public class KhataManagement1
    {
        private int TotalSalBal = 0;
        public void SaleAmount(int salAmt)
        {
            if (salAmt >= 40000)
            {
                Console.WriteLine("You should clear your loan first!");
            }
            else
            {
                TotalSalBal += salAmt;
                Console.WriteLine("Your Sale balance credited : "+ TotalSalBal);
            }
        }

        public int GetSalBalance()
        {
            return TotalSalBal;
        }
    }

    public static class Break
    {
        public static void PrintBreak()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-----------------------------------------");
        }
    }


    public class Temp
    {

        
        static float mulbycel;
        static int addbycel;
        static Temp()
        {
            
            Temp.mulbycel = 1.8F;
            Temp.addbycel = 32;
        }
        public void CelToF(ref float userInput)
        {
            userInput =  userInput * Temp.mulbycel + Temp.addbycel;
            Console.WriteLine("Copy value : " + userInput);
        }

        //public int GetTemp()
        //{
        //    return TotalTemp;
        //}

    }
}

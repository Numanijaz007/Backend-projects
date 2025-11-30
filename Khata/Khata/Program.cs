namespace Khata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KhataManagement loan = new KhataManagement();
            Console.WriteLine("My Loan Balance is : " + loan.GetLoanBalance());
            //Console.WriteLine("Your sale amount is : " + Salar.GetLoanBalance());
            Break.PrintBreak();

            Console.Write("Enter Loan Amount : ");
            int a = int.Parse(Console.ReadLine());
            loan.LoanAmount(a);
            Console.WriteLine("My Loan Balance is : " + loan.GetLoanBalance());
            Break.PrintBreak();

            KhataManagement1 Salari = new KhataManagement1();
            Salari.SaleAmount(5000);
            Console.WriteLine("My Sale Balance is : " + Salari.GetSalBalance());
            Break.PrintBreak();

            Console.WriteLine("My Loan Balance is : " + loan.GetLoanBalance());
            Console.WriteLine("Your sale amount is : " + Salari.GetSalBalance());

            Temp op = new Temp();
            Console.Write("Enter Number to check temperature in fahrenheit : ");
            float d = float.Parse(Console.ReadLine());
            if (float.TryParse(Convert.ToString(d), out float result))
            {
                op.CelToF(ref d);
                Console.WriteLine("Your original value : " + d);
            }
            else
            {
                Console.WriteLine("You Entered Invalid Value!!!");
            }

        }

    }
}

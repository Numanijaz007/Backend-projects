using System.Runtime.CompilerServices;

namespace Types_and_Types_Members1
{
    public class FinanceDepartment
    {
        private int budget = 100;
        internal void CalculateBudget()
        {
            budget = budget + 100;
        }
        protected internal void ApproveBudget()
        {
            Console.WriteLine($"Your {budget} budget is approved successfully.");
        }
    }

    public class HRDepartment
    {
        public void Print1()
        {
            FinanceDepartment fun1 = new FinanceDepartment();
            fun1.CalculateBudget();
            fun1.ApproveBudget();
            Console.WriteLine("its your print mehtod 1");
        }
        [Obsolete]
        public void Print2()
        {
            FinanceDepartment fun2 = new FinanceDepartment();
            fun2.CalculateBudget();
            fun2.ApproveBudget();
            Console.WriteLine("its your print mehtod 2");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FinanceDepartment bud = new FinanceDepartment();
            bud.CalculateBudget();
            bud.ApproveBudget();

            HRDepartment hr = new HRDepartment();
            hr.Print1();

            hr.Print2();

        }
    }
}

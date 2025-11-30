namespace Delegates1
{
    internal class Program
    {

        public delegate bool IsSalary(int number);

        public static void CheckSalary(IsSalary salaryCheck)
        {
            bool isSalary = int.TryParse(Console.ReadLine(), out int salary);
            if (isSalary )
            {
                if(salaryCheck(salary))
                {
                    isSalary = true;
                    Console.WriteLine("Salary is greater than 5000");
                }
                else
                {
                    isSalary = false;
                    Console.WriteLine("Salary is less than 5000");
                }
            }
            else
            {
                Console.WriteLine("is not match");
            }
        }
        static void Main(string[] args)
        {
            CheckSalary(x=>x>=4000); 
        }
    }
}

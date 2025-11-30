namespace demoarr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] salaries = new int[5];
            int total = 0;

            for (int i = 0; i < salaries.Length; i++)
            {
                Console.Write($"Enter salary for employee {i + 1}: ");
                salaries[i] = int.Parse(Console.ReadLine());
                total += salaries[i];
            }

            float average = (float)total / salaries.Length;
            Console.WriteLine($"Total: {total}, Average: {average}");

        }
    }
}

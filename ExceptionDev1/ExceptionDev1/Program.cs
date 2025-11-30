using System.Collections.Generic;

namespace ExceptionDev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> DemoSize = new List<int>();
                DemoSize.Add(1);
                DemoSize.Add(2);
                DemoSize.Add(3);
                DemoSize.Add(4);
                DemoSize.Add(5);

                int[] DemoSizeArray = DemoSize.ToArray();
                Console.Write("Enter to check array number index : ");

                //int index = int.Parse(Console.ReadLine());
                bool isIndexCorrect = int.TryParse(Console.ReadLine(), out int index);

                if (isIndexCorrect)
                {
                    Console.WriteLine("Your Index value is {0}", DemoSizeArray[index]);
                }
                else
                {
                    Console.WriteLine("\nPlease enter valid index value between 0 To {0}!!!!!", DemoSizeArray.Length);
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

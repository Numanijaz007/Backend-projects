using System;
using System.IO;

namespace ExceptionDev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a Numerator : ");
                bool isNumeratorSuccessful = int.TryParse(Console.ReadLine(), out int Numerator);
                if (isNumeratorSuccessful)
                {
                    Console.Write("Enter a Denominator : ");
                    bool isDenominatorSuccessful = int.TryParse(Console.ReadLine(), out int Denominator);

                    if (isDenominatorSuccessful && Denominator != 0)
                    {
                        int result = Numerator / Denominator;
                        Console.WriteLine(result);
                    }
                    else
                    {
                        if (Denominator == 0)
                        {
                            Console.WriteLine("Denominator Should not be 0!");
                        }
                        else
                        {
                            Console.WriteLine("Only numbers are allowed between {0} to {1} ", int.MinValue, int.MaxValue);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Only numbers are allowed between {0} to {1} ", int.MinValue, int.MaxValue);
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Calculation Complete...");
            }
        }
    }
}

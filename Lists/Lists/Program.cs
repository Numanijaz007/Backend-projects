using System;
using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List <string> numbers = new List<string> {"20", "30", "40", "50", "60", "70" };
            numbers.Add ("1");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.RemoveAt(0);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Remove ("60");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Insert(4, "33");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Reverse ();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Sort ();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            if(numbers.Contains("73"))
            {
                Console.WriteLine("Yes");
                //foreach (var item in numbers)
                //{
                //    Console.WriteLine(item);
                //}
            }
            else
            {
                Console.WriteLine("No");
            }
            
            //string result = numbers.Find(f => f.StartsWith(20));

        }
    }
}

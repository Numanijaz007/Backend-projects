using System;
using System.Collections.Generic;


namespace Dictionary3
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> product = new Dictionary<string, double>()
            {
               {"Colgate", 200},
               { "Diary", 700 },
               { "Tissue", 20 },
               { "Charger", 1200 },
               { "Bags", 1000 }
            };

            Console.WriteLine("Product List : ");
            foreach (var item in product)
            {
                Console.WriteLine($"{item.Key} , {item.Value}");
            }

            Console.WriteLine("\nApplying 10% Discount On all products.");
            List<string> Keys = new List<string>(product.Keys);
            foreach (var key in Keys)
            {
                product[key] = product[key] * 0.90;
                
            }

            Console.WriteLine("Updated prices with 10% discount on all products.");
            Console.WriteLine();
            foreach (var item1 in product)
            {
                
                Console.WriteLine($"{item1.Key} , {item1.Value}");
            }

            var maxProduct = product.Aggregate((x,y) => x.Value > y.Value ?x:y);
            var minProduct = product.Aggregate((x,y) => x.Value < y.Value ?x:y);

            Console.WriteLine($"\nExpensive Product : {maxProduct.Key} , {maxProduct.Value}");
            Console.WriteLine($"Cheapest Product : {minProduct.Key} , {minProduct.Value}");

            Console.WriteLine();
            var total = product.Sum(x => x.Value);
            Console.WriteLine("Total Products Value with 10% Discount : " + total);
        }
    }
}

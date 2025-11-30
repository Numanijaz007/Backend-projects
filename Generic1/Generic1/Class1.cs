using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic1
{
    public class Customer
    {
        public void Get()
        {
            Class1 na = new Class1();
            na.Name = "A";
            na.Random = "N";

            Class1 na2 = na;

            Console.WriteLine(na2.GetType().Name);
        }
        
        
    }
    internal class Class1
    {
        public string Name { get; set; }
        public string Random { get; set; }

        public void Print()
        {
            bool index = Calculator<string>.AreEqual("Numan", "ijaz");
            Console.WriteLine(index);
        }
    }
}

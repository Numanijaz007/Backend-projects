using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace Generic2
{
    public class Box<T>
    {
        private T _item;
        public void Add(T item)
        {

            _item = item;
            Console.WriteLine($"{_item} Added Successfully");

        }
        public T GetItem()
        {
            return _item;
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Box<int> idbox = new Box<int>();
            idbox.Add(221);
            Console.WriteLine("Box Contains Id " + idbox.GetItem());

            Console.WriteLine();

            Box<string> textbox = new Box<string>();
            textbox.Add("The Partial");
            Console.WriteLine("Box Contain Book: " + textbox.GetItem());

            Console.WriteLine();

            Box<Product> productinfo = new Box<Product>();
            productinfo.Add(new Product
            {
                Name = "Rich Dad and Poor Dad",
                Price = 12000

            });
            Box<Product> productinfo1 = new Box<Product>();
            productinfo1.Add(new Product
            {
                Name = "Rich Dad and Poor Dad",
                Price = 13000

            });
            Box<Product> productinfo2 = new Box<Product>();
            productinfo2.Add(new Product
            {
                Name = "Rich Dad and Poor Dad",
                Price = 14000

            });
           
            var product1 = productinfo.GetItem();
            var product2 = productinfo1.GetItem();
            var product3 = productinfo2.GetItem();
            Console.WriteLine();
            Console.WriteLine("Product 1 Title: " + product1.Name + " , " + "Product Price: " + product1.Price);
            Console.WriteLine("Product 2 Title: " + product2.Name + " , " + "Product Price: " + product2.Price);
            Console.WriteLine("Product 3 Title: " + product3.Name + " , " + "Product Price: " + product3.Price);
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Name}-{Price}";
        }
    }



}

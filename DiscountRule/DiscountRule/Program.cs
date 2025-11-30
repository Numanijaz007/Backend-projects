namespace DiscountRule
{

    interface IWinterProducts
    {
        string GetName();
        string GetColor();
        string GetCategory();
    }

    interface ISummerProducts : IWinterProducts
    {

    }

    public abstract class Discount
    {
        public abstract void GetDiscount();

    }

    public  class Product1 : Discount , IWinterProducts
    {
        public string GetName()
        {
            return " Basic Sweatshirt";
        }

        public string GetColor()
        {
            return "Black";
        }

        public string GetCategory()
        {
            return "SweatShirts/Hoodies";
        }

        public override void GetDiscount()
        {
            int discount = 50;
            Console.WriteLine("Discount is {0}%",discount);
            return;
        }
    }


    public class Product2 : Discount, IWinterProducts
    {
        public string GetName()
        {
            return "Mock Neck Polo";
        }

        public string GetColor()
        {
            return "Grey";
        }

        public string GetCategory()
        {
            return "SweatShirts/Hoodies";
        }
        public override void GetDiscount()
        {
            int discount = 50;
            Console.WriteLine("Discount is {0}%", discount);
            return;
        }
    }

    public class Product3 : Discount, ISummerProducts
    {
        public string GetName()
        {
            return "Stripes T-Shirt";
        }

        public string GetColor()
        {
            return "Blue";
        }

        public string GetCategory()
        {
            return "T-Shirt";
        }
        public override void GetDiscount()
        {
            int discount = 70;
            Console.WriteLine("Discount is {0}%", discount);
            return;
        }
    }

    public class Product4 : Discount, ISummerProducts
    {
        public string GetName()
        {
            return "Linen Button Down Shirt";
        }

        public string GetColor()
        {
            return "Brown";
        }

        public string GetCategory()
        {
            return "Casual Shirts";
        }
        public override void GetDiscount()
        {
            int discount = 70;
            Console.WriteLine("Discount is {0}%", discount);
            return;
            
        }
    }

    public class Product5 : Discount, ISummerProducts
    {
        public string GetName()
        {
            return "Linennnnnn Button Down Shirt";
        }

        public string GetColor()
        {
            return "Brown";
        }

        public string GetCategory()
        {
            return "Casual Shirts";
        }
        public override void GetDiscount()
        {
            int discount = 90;
            Console.WriteLine("Discount is {0}%", discount);
            return;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IWinterProducts winterProducts1 = new Product1();

            Console.WriteLine("Title : {0}", winterProducts1.GetName());
            Console.WriteLine("Color : {0}", winterProducts1.GetColor());
            Console.WriteLine("Category : {0}", winterProducts1.GetCategory());

            Discount discount1 = new Product1();
            discount1.GetDiscount();


            IWinterProducts winterProducts2 = new Product2();

            Console.WriteLine("\nTitle : {0}", winterProducts2.GetName());
            Console.WriteLine("Color : {0}", winterProducts2.GetColor());
            Console.WriteLine("Category : {0}", winterProducts2.GetCategory());

            Discount discount2 = new Product2();
            discount2.GetDiscount();


            ISummerProducts summerProducts3 = new Product3();

            Console.WriteLine("\nTitle : {0}", summerProducts3.GetName());
            Console.WriteLine("Color : {0}", summerProducts3.GetColor());
            Console.WriteLine("Category : {0}", summerProducts3.GetCategory());

            Discount discount3 = new Product3();
            discount3.GetDiscount();


            ISummerProducts summerProducts4 = new Product4();

            Console.WriteLine("\nTitle : {0}", summerProducts4.GetName());
            Console.WriteLine("Color : {0}", summerProducts4.GetColor());
            Console.WriteLine("Category : {0}", summerProducts4.GetCategory());

            Discount discount4 = new Product4();
            discount3.GetDiscount();

            ISummerProducts summerProducts5 = new Product5();

            Console.WriteLine("\nTitle : {0}", summerProducts5.GetName());
            Console.WriteLine("Color : {0}", summerProducts5.GetColor());
            Console.WriteLine("Category : {0}", summerProducts5.GetCategory());

            Discount discount5 = new Product5();
            discount5.GetDiscount();


        }
    }
}

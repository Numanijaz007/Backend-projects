using System.Reflection;

namespace Reflection1
{
    public interface ICar
    {
       
        void GetName();
        void GetColor();
        void GetModel();

    }
    public class BMW : ICar
    {
        public int MyProperty { get; set; }
        public void GetName()
        {
            Console.WriteLine("BMW");
        }
        public void GetColor()
        {
            Console.WriteLine("Black");
        }
        public void GetModel()
        {
            Console.WriteLine("2023");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
            BMW bmw = new BMW();

            Type type = bmw.GetType();

            Console.WriteLine($"Class Name: " + type.Name);
            Console.WriteLine($"Namespace Name: " + type.Namespace);

            foreach (var item in type.GetMethods())
            {
                Console.WriteLine("Method Names: "+item.Name);
            }

            var car1 = Activator.CreateInstance(type);
            //MethodInfo info = new MethodInfo();

            foreach (var item in car1.GetType().GetProperties())
            {
                if(item.Name == "MyProperty")
                {
                    item.SetValue(car1, 20);
                    
                }
                Console.WriteLine("Properties Names: "+ item.Name +" "+ item.PropertyType.Name);
            }


        }
    }
}

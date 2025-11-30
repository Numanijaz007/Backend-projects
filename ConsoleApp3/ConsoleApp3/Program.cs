namespace ConsoleApp3
{
    public struct Student
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string GetInfo()
        {
            return Name+" "+Address ;
        }
    }

    public interface ICar
    {
        string GetName();
        string GetModel();
        string GetBrand();
        string GetSize(int widt, int height);
    }

    public interface IEngine:ICar
    {
        string GetEngineVersion();

    }



    public class BMW : IEngine
    {
        public string GetBrand()
        {
            return "BMW";
        }

        public string GetModel()
        {
            return "2024";
        }

        public string GetName()
        {
            return "Etron";
        }
        public string GetSize(int width, int height)
        {
            return width+ " "+height;
        }

        public string GetEngineVersion()
        {
            return "2028.1261.3333";
        }
    }

    public class Audi : ICar
    {
        public string GetBrand()
        {
            return "Audi";
        }

        public string GetModel()
        {
            return "2024";
        }

        public string GetName()
        {
            return "X400";
        }
        public string GetSize(int width, int height)
        {
            return width + " " + height;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Student ss = new Student();
            //ss.Name = "sasasa";
            //ss.Address = "fadsadsadsa";


            ICar car = new BMW();
            car.GetName();
            car.GetModel();
            car.GetBrand();




            ICar car2 = new Audi();
            car2.GetName();
            car2.GetModel();
            car2.GetBrand();



            Console.WriteLine(car.GetName());
            Console.WriteLine(car.GetModel());
            Console.WriteLine(car.GetBrand());
        }
    }
}

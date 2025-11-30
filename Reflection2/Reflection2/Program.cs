using System.Reflection;

namespace Reflection2
{
    public interface ICar
    {

        void GetName();
        void GetColor(string color);
        void GetModel();

    }
    public class BMW : ICar
    {
        public int MyProperty { get; set; }
        public void GetName()
        {
            Console.WriteLine("BMW");
        }
        public void GetColor(string color)
        {
            Console.WriteLine("Black " + color);
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
            //Methods invocation

            BMW bmw = new BMW();
            Type type = typeof(BMW);
            object obj = Activator.CreateInstance(type);

            MethodInfo methodInfos = type.GetMethod("GetColor");
            //MethodBase methodInfos1 = type.DeclaringMethod;
            Console.WriteLine(methodInfos);
            methodInfos.Invoke(obj, new object[]
            {
                "White"
            });




            string className = "Reflection2.BMW";
            Type type1 = Type.GetType(className);
            object obj1 = Activator.CreateInstance(type1);


            MethodInfo info = type1.GetMethod("GetName");
            info.Invoke(obj1,null);

        }
    }
}

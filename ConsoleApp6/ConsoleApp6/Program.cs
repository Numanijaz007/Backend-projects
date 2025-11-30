using ConsoleApp6.Test;
using System.Reflection;
using System.Text;

namespace ConsoleApp6
{
    internal class Program
    {
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        static void Main(string[] args)
        {

            //Student student = new Student();
            //student.FirstName = "Salman";
            //student.LastName = "Ahmed";

            //var dd =  typeof(Student).Namespace;
            //var ff = typeof(Student).Name;

            //StringBuilder name = new StringBuilder("Numan");
            //name.Append(" ijaz Ul hassan");
            //name.Append(" Mughal");
            //Console.WriteLine(name.ToString());


            // Console.WriteLine(student.GetType().Name);
            // Console.WriteLine(student.GetType().Namespace);


            Student ss = new Student();
            var sb1 = Type.GetType("ConsoleApp6.Test.Student");
            Console.WriteLine(sb1.FullName);
            foreach (var item in sb1.GetProperties())
            {
                Console.WriteLine(item.Name + " " + item.PropertyType.Name);
            }


            foreach (var item in sb1.GetMethods())
            {
                Console.WriteLine(item.Name);
            }

            foreach (var item in sb1.GetConstructors())
            {
                Console.WriteLine(item.Name);
            }


            var student1 = Activator.CreateInstance(sb1);
            foreach (var prop in student1.GetType().GetProperties())
            {
                if (prop.Name == "FirstName")
                {
                    prop.SetValue(student1, "Salman");
                }
                if (prop.Name == "LastName")
                {
                    prop.SetValue(student1, "Rasheed");
                }

            }


            var methodToCall = student1.GetType().GetMethod("GetInfo");
            var dd = methodToCall.Invoke(student1, null);
            Console.WriteLine(dd);

            var ddd = Assembly.GetExecutingAssembly().FullName;

            Console.WriteLine(ddd);




            foreach (var item in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (item.Name != "Program")
                {
                    var obj = Activator.CreateInstance(item);
                    var method = item.GetMethod("GetInfo");
                    Console.WriteLine(method.Invoke(obj, null));
                }

            }





        }
    }
}

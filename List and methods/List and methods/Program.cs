namespace List_and_methods
{

    //public class UserAccount
    //{
    //    public string Name { get; set; }
    //    public string PIN { get; set; }
    //    public int Balance { get; set; }
    //}



    internal class Program
    {

        public static int GetSum(int number1, int number2)
        {

            return number1 + number2;
        }

        public static string EvenNumbers(int i)
        {
            return i % 2 == 0 ? "Your Number is even" : "Your number is odd"; 
        }

        public static float CelToF(int userInput , float mulbycel = 1.8F, int addbycel = 32)
        {
            return userInput * mulbycel + addbycel;
        }

        public static float FToCel(int userInput, int subbycel = 32 , float divbycel = 1.8F)
        {
            return (userInput - subbycel) / divbycel;
        }


        public static void PrintMyNumber(int n)
        {
            n = n + 1;
            Console.WriteLine("Value of n is:"+n);
        }
        public static void PrintMyNumberzzz(ref int n)
        {
            n = n + 1;
            Console.WriteLine("Value of n is:" + n);
        }

        public static void GetFiveMultiplier(ref int val1,ref int val2,ref int val3)
        {
            val1 = val1 * 5;
            val2 = val2 * 5;
            val3 = val3 * 5;
        }


        public static void GetSalary(ref int salary)
        {
            salary = (salary * 10) / 100;

        }


        static void Main(string[] args)
        {

            int sal = 50000;
            GetSalary(ref sal);
            Console.WriteLine(sal);



            //int a = 10;
            //PrintMyNumberzzz(ref a);
            //Console.WriteLine("value of a is:"+a);

            //int a = 10;
            //int b = 20;
            //int c = 30;
            //GetFiveMultiplier(ref a, ref b, ref c);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);


            //GetSum Method
            //Console.WriteLine("GetSum Method");
            //int n1 = 1987;
            //int n2 = 2000;
            //int result = GetSum(n1, n2);
            //Console.WriteLine(result);

            ////EvenNumbers Method
            //Console.WriteLine("EvenNumbers Method");
            //int number = int.Parse(Console.ReadLine());
            ////if (number % 2 == 0)
            ////{
            ////    Console.WriteLine("Your Number is Even...");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Your Number is Odd...");
            ////}
            //string result1 = EvenNumbers(number);

            //Console.WriteLine(result1);

            ////CelToF Method
            //Console.WriteLine("Cels to Farh temp Method");
            //int temp1 = int.Parse(Console.ReadLine());
            //float result2 = CelToF(temp1);
            //Console.WriteLine(result2);


            ////FToCel Method
            //Console.WriteLine("Farh to cels temp Method");
            //int temp2 = int.Parse(Console.ReadLine());
            //float result3 = FToCel(temp2);
            //Console.WriteLine(result3);






            //List<UserAccount> accounts = new List<UserAccount>();
            //accounts.Add(new UserAccount { Name = "Salman", PIN = "1234", Balance = 1000 });
            //accounts.Add(new UserAccount { Name = "Noman", PIN = "2345", Balance = 2000 });
            //do
            //{
            //    Console.WriteLine("Please enter your PIN:");
            //    var pin = Console.ReadLine();
            //    accounts.Any(z => z.PIN == pin);
            //    break;

            //}
            //while (true);




            //List<string> list = new List<string>();

            //Console.WriteLine("Please enter your name");
            //var name = Console.ReadLine();
            //Console.WriteLine("Please enter your class name");
            //var className = Console.ReadLine();
            //Console.WriteLine("Please enter your age");
            //var age = Console.ReadLine();
            //list.Add("You entered the name :" + name);
            //list.Add(age);
            //list.Add(className);
            //Console.WriteLine("Here are you answers:");



            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();





        }



        


       
    }
}

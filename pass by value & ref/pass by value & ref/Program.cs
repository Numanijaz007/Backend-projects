using System.ComponentModel.Design.Serialization;
using System.Transactions;
using pass_by_value___ref1;

namespace pass_by_value___ref
{
    

    internal class Program
    {
        

        //swapping numbers
        //public static void SwapTwoNumVal(int a)
        //{
        //    a = a + 1;
        //    Console.WriteLine("Value of a is swapped by value: " + a);
        //}
        //public static void SwapTwoNumRef(ref int b, ref int c)
        //{
        //    b = b + 1;
        //    c = c + 2;
        //    Console.WriteLine("Value of b is swapped by ref: " + b);
        //    Console.WriteLine("Value of c is swapped by ref: " + c);
        //}


        //square a number
        //public static void SqNumByVal(int a)
        //{
        //    double p = Math.Pow(a, 2);
        //    Console.WriteLine(p);
        //}
        //public static void SqNumByRef(ref double a)
        //{
        //    a = Math.Pow(a, 2);
        //    Console.WriteLine(a);
        //}

        //doubles integer
        //public static void DbIntVal(int a)
        //{
        //    a = a * 2;
        //    Console.WriteLine(a);
        //}
        //public static void DbIntRef(ref int a)
        //{
        //    a = a * 2;
        //    Console.WriteLine(a);
        //}

        //increase salary by 10%
        //public static void IncSalary(int sal)
        //{
        //    sal = (sal * 10) / 100;
        //    Console.WriteLine(sal);
        //}
        //public static void IncSalary(ref int sal)
        //{
        //    sal = (sal * 10) / 100;
        //    Console.WriteLine("by ref : "+sal);
        //}

        //Temperature Converter

        //public static void CelToF(int userInput, float mulbycel= 1.8F, int addbycel = 32)
        //{
        //    userInput = (int)(userInput * mulbycel) + addbycel;
        //    Console.WriteLine("Copy value : " + userInput);
        //}
        //public static void CelToF(ref int userInput, ref float mulbycel, ref int addbycel)
        //{
        //    mulbycel = 1.8F;
        //    addbycel = 32;
        //    userInput = (int)(userInput * mulbycel + addbycel);
        //    Console.WriteLine("Copy value : " + userInput);
        //}

        //Bank Account
        //static int balance = 1000;
        //public static void BankDep(ref int dep)
        //{
        //    balance = balance + dep;
        //}
        //public static void BankWith(ref int with)
        //{
        //    balance = balance - with;
        //}
        //public int TotalBalance()
        //{
        //    return balance;
        //}
        //public static void Break()
        //{
        //    Console.WriteLine("------------------------------");
        //    Console.WriteLine("------------------------------");
        //}

        //student info 

        static void Main(string[] args)
        {

            // student info
            Console.WriteLine("Write any Code here : q");
            StudentInfo student = new StudentInfo();
            //student.NameFun(student.Name);
            //student.MarkFun(student.Marks);



            //Bank account
            //Console.WriteLine("Your Total Balance is : "+ balance);
            //Program.Break();

            //Console.Write("Enter Your Deposit Amount : ");
            //int f = int.Parse(Console.ReadLine());
            //BankDep(ref f);
            //Console.WriteLine("Your Balance is : "+ balance );
            //Program.Break();

            //Console.Write("Enter Your Withdrawl Amount : ");
            //int w = int.Parse(Console.ReadLine());
            //BankWith(ref w);
            //Console.WriteLine("Your Balance is : " + balance);




            //Temperature Converter
            //Console.Write("Enter value to check temperature Celsius to fahrenheit: ");
            //int t = int.Parse(Console.ReadLine());
            //CelToF(t);
            //Console.WriteLine("original value : "+t);


            //Console.Write("Enter value to check temperature Celsius to fahrenheit: ");
            //float a = 0;
            //int b = 0;
            //int t = int.Parse(Console.ReadLine());
            //CelToF(ref t , ref a , ref b);
            //Console.WriteLine("original value : " + t);


            //swapping numbers
            //Console.WriteLine("Enter value to check Numbers is swapped by value or not:");
            //int n = int.Parse(Console.ReadLine());
            //SwapTwoNumVal(n);
            //Console.WriteLine("Value of n is not swapped by value: " + n);


            //Console.WriteLine("\nEnter value to check Numbers is swapped by Ref or not:");
            //int m = int.Parse(Console.ReadLine());
            //int m1 = int.Parse(Console.ReadLine());
            //SwapTwoNumRef(ref m, ref m1);
            //Console.WriteLine("Value of m is swapped by ref: " + m);
            //Console.WriteLine("Value of m1 is swapped by ref: " + m1);



            //square numbers
            //Console.WriteLine("Enter any number to find square");
            //int s = int.Parse(Console.ReadLine());
            //SqNumByVal(s);
            //Console.WriteLine(s);


            //Console.WriteLine("Enter any number to find square");
            //double s1 = int.Parse(Console.ReadLine());
            //SqNumByRef(ref s1);
            //Console.WriteLine("original value : " + s1);



            //doubles integer
            //Console.Write("Enter any number to double it : ");
            //int d = int.Parse(Console.ReadLine());
            //DbIntVal(d);
            //Console.WriteLine(d);


            //Console.Write("Enter any number to double it : ");
            //int d1 = int.Parse(Console.ReadLine());
            //DbIntRef(ref d1);
            //Console.WriteLine("Original value : " + d1);

            //increase salary by 10%
            //Console.WriteLine("Enter salary to get percentage : ");
            //int p = int.Parse(Console.ReadLine());
            //IncSalary(p);
            //Console.WriteLine("Your 10% percentage salary is " + p);


            //Console.WriteLine("Enter salary to get percentage by ref : ");
            //int p1 = int.Parse(Console.ReadLine());
            //IncSalary(ref p1);
            //Console.WriteLine("Your 10% percentage salary is " + p1);


        }




    }
}

using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter your username:");
            //var test = Console.ReadLine();
            //Console.WriteLine("----------");
            //Console.Write("Enter your password:");
            //var pass = Console.ReadLine();
            //Console.WriteLine("Your credentials have been saved");
            //Console.ReadKey();







            //bool isCat = true;
            //string name = isCat ?"Cat":"Dog" ;
            //if(name == "Dog")
            //{
            //    Console.WriteLine("This is a dog");
            //}





            //string flag = null;
            //flag = flag ?? "Test";
            //Console.WriteLine(flag);
            //Console.ReadKey();
            //int n1 = 0;





            //Explicit data type casting
            //string number = "27";
            //int a = int.Parse(number) ;

            //string dd = "22.67";
            //float f= float.Parse(dd) ;






            ////Implicity casting
            //int aa = (int)f;

            //string sensor = "199999";
            //int.TryParse(sensor, out int result);


            //Console.WriteLine(result);
            //string input = Console.ReadLine();

            //if (int.TryParse(input, out int result))
            //{
            //    Console.WriteLine("Your Entered Number is {0}", result);
            //}
            //else {
            //    Console.WriteLine("You Entered Number is Invalid !");
            //}





            //string ss = "test";
            //switch (ss)
            //{
            //    case "tepo":
            //        Console.WriteLine("your name is tepo");
            //        break;
            //    case "demo":
            //        Console.WriteLine("your name is demo");
            //        break;

            //    default:
            //        Console.WriteLine("Hey ");
            //        break;
            //}



            //assignment
            //string? input = Console.ReadLine();
            ////Console.WriteLine(input);


            //if (int.TryParse(input, out int number))
            //{
            //    Console.WriteLine("You have entered an integer.");
            //}
            //else if (float.TryParse(input, out float result))
            //{
            //    Console.WriteLine("You have entered a decimal.");
            //}
            //else if (char.TryParse(input, out char result1))
            //{
            //    Console.WriteLine("you have entered a character.");
            //}
            //else if (Regex.IsMatch(input!, @"^[A-Za-z]+$"))
            //{
            //    Console.WriteLine("You have entered word");
            //}
            //else if (Regex.IsMatch(input!, @"^[A-Za-z\s]+$"))
            //{
            //    Console.WriteLine("You have entered a string.");
            //}
            //else
            //{
            //    Console.WriteLine("You have entered Nothing.");
            //}


            //assignment
            //string input = Console.ReadLine();

            //switch (input)
            //{
            //    case value0(int.TryParse(input, out int number)):
            //        Console.WriteLine("You have entered Integer");
            //        break;

            //    case value1(float.TryParse(input, out float result)):
            //        Console.WriteLine("You have entered decimal value");
            //        break;

            //    case value2(char.TryParse(input, out char result1)):
            //        Console.WriteLine("You have entered a Character");
            //        break;

            //    default:
            //        Console.WriteLine("you have entered string");
            //        break;
            //}


            ////Arrays
            //int[] numbers  = new int[] { 1, 2, 3};
            ////int[] numbers = new int[10];
            ////numbers[2] = 100;


            ////loops
            //Console.WriteLine("FOR Loop");
            //for (int i=0;i<numbers.Length;i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.WriteLine("WHILE Loop");
            //int j = 0;
            //while (j<numbers.Length)
            //{
            //    Console.WriteLine(numbers[j]);
            //    j++;
            //}
            //Console.WriteLine("FOREACH Loop");
            //foreach (int item in numbers)
            //{

            //    Console.WriteLine(item);

            //}

            //Console.WriteLine("Do WHILE Loop");
            //int k = 0;
            //do
            //{
            //    Console.WriteLine(numbers[k]);
            //    k++;
            //}
            //while (k<numbers.Length);







            //assignment
            // Console.WriteLine("Enter any value to find type :");
            // string? input = Console.ReadLine();

            // if (int.TryParse(input, out int number))
            // {
            //     Console.WriteLine("You have entered an integer.");
            // }
            // else if (float.TryParse(input, out float result))
            // {
            //     Console.WriteLine("You have entered a decimal.");
            // }
            // else if (char.TryParse(input, out char result1))
            // {
            //     Console.WriteLine("you have entered a character.");
            // }
            // else if (Regex.IsMatch(input!, @"^[A-Za-z]+$"))
            // {
            //     Console.WriteLine("You have entered word");
            // }
            // else if (Regex.IsMatch(input!, @"^[A-Za-z\s]+$"))
            // {
            //     Console.WriteLine("You have entered a string.");
            // }
            // else
            // {
            //     Console.WriteLine("You have entered Nothing.");
            // }


            //Console.WriteLine("Do you want to do another try or exit (y/n).");
            //string userDecision = Console.ReadLine();
            


            //Console.WriteLine("Do you want to start the program? (y/n)");
            //string userDecision = Console.ReadLine();

            //while (userDecision.ToUpper() == "Y")
            //{
            //    Console.WriteLine("Enter any value to find type :");
            //    string? input = Console.ReadLine();

            //    if (int.TryParse(input, out int number))
            //    {
            //        Console.WriteLine("You have entered an integer.");
            //    }
            //    else if (float.TryParse(input, out float result))
            //    {
            //        Console.WriteLine("You have entered a decimal.");
            //    }
            //    else if (char.TryParse(input, out char result1))
            //    {
            //        Console.WriteLine("you have entered a character.");
            //    }
            //    else if (Regex.IsMatch(input!, @"^[A-Za-z]+$"))
            //    {
            //        Console.WriteLine("You have entered word");
            //    }
            //    else if (Regex.IsMatch(input!, @"^[A-Za-z\s]+$"))
            //    {
            //        Console.WriteLine("You have entered a string.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You have entered Nothing.");
            //    }

            //    Console.WriteLine("Do you want to do another try or exit (y/n).");
            //    userDecision = Console.ReadLine();
            //}
            //Console.WriteLine("Program end !");




            
            Console.WriteLine("Do you want Coffee : [Yes/No]");
            string userDecision = Console.ReadLine();
            

            int totalCoffeeCost = 0;

            while (userDecision.ToUpper() == "YES")
            {
                Console.Write("Select Your Coffee Size : ");
                Console.WriteLine("1-Small , 2-Medium , 3-Large");
                int userInput = int.Parse(Console.ReadLine());
                
                if (userInput == 1)
                {
                    totalCoffeeCost += 1;
                    //Console.WriteLine("You buy ${0} small coffee ", totalCoffeeCost);
                }
                else if (userInput == 2)
                {
                    totalCoffeeCost += 2;
                    //Console.WriteLine("You buy ${0} medium coffee ", totalCoffeeCost);
                }
                else if (userInput == 3)
                {
                    totalCoffeeCost += 3;
                    //Console.WriteLine("You buy ${0} large coffee ", totalCoffeeCost);
                }
                else
                {
                    Console.WriteLine("You entered invalid choice....Please try again!");
                }

                Console.WriteLine("Do you want to buy more coffee...Yes/no");
                userDecision = Console.ReadLine();

                

            }
            
                Console.WriteLine("Your Total bill amount is ${0}", totalCoffeeCost);
                Console.WriteLine("Thanks For Shopping With Us!");
            
            
        }
    }
}
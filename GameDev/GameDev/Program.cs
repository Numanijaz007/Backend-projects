using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace GameDev
{
    interface IcharachterAction
    {
        string GetName();
        void GetPower();
        string GetHealth();
        int GetLevel();
    }
    public abstract class Fight
    {
        public abstract void GetPunch1();
        public abstract void GetKick1();
        public abstract void Defend();
        public abstract void GetHook();

    }

    public class Warrior : Fight, IcharachterAction
    {
        public string GetName()
        {
            return "Warrior";
        }

        public void GetPower()
        {
            Console.Write("Enter Warrior Power From 0 - 500% : ");
            int d = int.Parse(Console.ReadLine());
            if (d >= 0 && d <= 100)
            {
                Console.WriteLine("You Unlock Slightly Power....");
            }
            else if (d >= 101 && d <= 200)
            {
                Console.WriteLine("You Unlock Slightly High Power....");
            }
            else if (d >= 201 && d <= 300)
            {
                Console.WriteLine("You Unlock High Power....");
            }
            else if (d >= 301 && d <= 400)
            {
                Console.WriteLine("You Unlock More High Power....");
            }
            else if (d >= 401 && d <= 500)
            {
                Console.WriteLine("You Unlock very High Power....");
            }
            else
            {
                Console.WriteLine("You Entered Invalid Power Value!!!");
            }
        }

        public string GetHealth()
        {
            return "Normal";
        }

        public int GetLevel()
        {
            return 5;
        }
        public override void GetPunch1()
        {
            Console.Write("\nChoose strike for fight against Enemy: ");
            Console.WriteLine("1 : Punch   2 : Kick   3 : Defend   4 : Hook");

            string userStrike = Console.ReadLine();
            Fight strikes = null;
            if (userStrike == "1")
            {
                //GetPunch1();
                Console.WriteLine("Punch.....");
            }
            else if (userStrike == "2")
            {
                GetKick1();
                //Console.WriteLine("Kick.....");
            }
            else if (userStrike == "3")
            {
                Defend();
                //Console.WriteLine("Defend.....");
            }
            else if (userStrike == "4")
            {
                GetHook();
                //Console.WriteLine("Hook.....");
            }
            else
            {
                Console.WriteLine("You entered invalid strike!.");
            }
        }

        public override void GetKick1()
        {
            Console.WriteLine("Kick.....");
        }

        public override void Defend()
        {
            Console.WriteLine("Defend.....");
        }

        public override void GetHook()
        {
            Console.WriteLine("Hook.....");
        }
    }


    public class Archer : Fight, IcharachterAction
    {
        public string GetName()
        {
            return "Archer";
        }

        public void GetPower()
        {
            Console.Write("Enter Archer Power From 0 - 500% : ");
            int pow = int.Parse(Console.ReadLine());
            if (pow >= 0 && pow <= 100)
            {
                Console.WriteLine("You Unlock Slightly Power....");
            }
            else if (pow >= 101 && pow <= 200)
            {
                Console.WriteLine("You Unlock Slightly High Power....");
            }
            else if (pow >= 201 && pow <= 300)
            {
                Console.WriteLine("You Unlock High Power....");
            }
            else if (pow >= 301 && pow <= 400)
            {
                Console.WriteLine("You Unlock More High Power....");
            }
            else if (pow >= 401 && pow <= 500)
            {
                Console.WriteLine("You Unlock very High Power....");
            }
            else
            {
                Console.WriteLine("You Entered Invalid Power Value!!!");
            }

        }

        public string GetHealth()
        {
            return "Peak Medium";
        }

        public int GetLevel()
        {
            return 10;
        }
        public override void GetPunch1()
        {
         

        }

        public override void GetKick1()
        {
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }

        public override void GetHook()
        {
            throw new NotImplementedException();
        }
    }

    public class Wizard : Fight, IcharachterAction
    {
        public string GetName()
        {
            return "Wizard";
        }

        public void GetPower()
        {
            Console.Write("Enter Wizard Power From 0 - 500% : ");
            int pow = int.Parse(Console.ReadLine());
            if (pow >= 0 && pow <= 100)
            {
                Console.WriteLine("You Unlock Slightly Power....");
            }
            else if (pow >= 101 && pow <= 200)
            {
                Console.WriteLine("You Unlock Slightly High Power....");
            }
            else if (pow >= 201 && pow <= 300)
            {
                Console.WriteLine("You Unlock High Power....");
            }
            else if (pow >= 301 && pow <= 400)
            {
                Console.WriteLine("You Unlock More High Power....");
            }
            else if (pow >= 401 && pow <= 500)
            {
                Console.WriteLine("You Unlock very High Power....");
            }
            else
            {
                Console.WriteLine("You Entered Invalid Power Value!!!");
            }

        }

        public string GetHealth()
        {
            return "High Performance";
        }

        public int GetLevel()
        {
            return 20;
        }
        public override void GetPunch1()
        {
         
        }

        public override void GetKick1()
        {
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }

        public override void GetHook()
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //IcharachterAction player = null;
            Console.WriteLine("Do You Want to play the Ninja Game....[yes/no]");
            string userDecision = Console.ReadLine();
            
            while (userDecision.ToUpper() == "YES")
            {
                IcharachterAction player = null;

                Console.WriteLine("Select Any Player : 1 : Warrior   2 : Archer   3 : Wizard");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput == 1)
                {
                    player = new Warrior();
                }
                else if (userInput == 2)
                {
                    player = new Archer();
                }
                else if (userInput == 3)
                {
                    player = new Wizard();
                }
                else
                {
                    Console.WriteLine("You entered invalid value!");
                }

                //IcharachterAction warrior = new Warrior();
                Console.WriteLine($"Player Name : {(player.GetName())}");
                player.GetPower();
                Fight punch1 = new Warrior();
                punch1.GetPunch1();
                Console.WriteLine(player.GetName() + " Health is :" + player.GetHealth());
                Console.WriteLine(player.GetName() + " Level is :" + player.GetLevel());

                Console.WriteLine("\nDo You Want to play again....[yes/no]");
                userDecision = Console.ReadLine();

            }
            Console.WriteLine("\nYou Exit The Game....");

            //IcharachterAction archer = new Archer();
            //Console.WriteLine("\nPlayer Name : {0}", (archer.GetName()));
            //archer.GetPower();
            //Punch punch2 = new Archer();
            //punch2.GetPunch1();
            //Console.WriteLine(archer.GetName() + " Health is :" + archer.GetHealth());
            //Console.WriteLine(archer.GetName() + " Level is :" + archer.GetLevel());

            //IcharachterAction wizard = new Wizard();
            //Console.WriteLine("\nPlayer Name : {0}", (wizard.GetName()));
            //wizard.GetPower();
            //Punch punch3 = new Wizard();
            //punch3.GetPunch1();
            //Console.WriteLine(wizard.GetName() + " Health is :" + wizard.GetHealth());
            //Console.WriteLine(wizard.GetName() + " Level is :" + wizard.GetLevel());


        }
    }
}

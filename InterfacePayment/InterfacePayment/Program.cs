namespace SmartDevice
{
    public interface ISmartDevice
    {

        string GetName();
        string GetModel();
        string GetType();
        string GetBrandName();
        string GetFeature();
    }

    public class Light : ISmartDevice
    {
        public string GetName()
        {
            return "Light";
        }
        public string GetModel()
        {
            return "2023";
        }
        public string GetType()
        {
            return "Wireless";
        }
        public string GetBrandName()
        {
            return "TCL";
        }
        public string GetFeature()
        {
            return "ANDROID";
        }
    }
    public class Fan : ISmartDevice
    {
        public string GetName()
        {
            return "Fan";
        }
        public string GetModel()
        {
            return "2025";
        }
        public string GetType()
        {
            return "Wall Fan";
        }
        public string GetBrandName()
        {
            return "Super Asia";
        }
        public string GetFeature()
        {
            return "Bluetooth";
        }
    }
    public class AC : ISmartDevice
    {
        public string GetName()
        {
            return "Inverter AC";
        }
        public string GetModel()
        {
            return "2025";
        }
        public string GetType()
        {
            return "Door AC";
        }
        public string GetBrandName()
        {
            return "Kenwood";
        }
        public string GetFeature()
        {
            return "Automatic Temperature Controlling";
        }
    }
    public class DoorLock : ISmartDevice
    {
        public string GetName()
        {
            return "Door Lock";
        }
        public string GetModel()
        {
            return "2025";
        }
        public string GetType()
        {
            return "Metal Door";
        }
        public string GetBrandName()
        {
            return "IKEA";
        }
        public string GetFeature()
        {
            return "Remote Control";
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            ISmartDevice light = new Light();
            light.GetName();
            light.GetModel();
            light.GetType();
            light.GetBrandName();
            light.GetFeature();


            ISmartDevice fan = new Fan();
            fan.GetName();
            fan.GetModel();
            fan.GetType();
            fan.GetBrandName();
            fan.GetFeature();

            ISmartDevice ac = new AC();
            ac.GetName();
            ac.GetModel();
            ac.GetType();
            ac.GetBrandName();
            ac.GetFeature();

            ISmartDevice door = new DoorLock();
            door.GetName();
            door.GetModel();
            door.GetType();
            door.GetBrandName();
            door.GetFeature();


            Console.Write("Do you want to check device information....[yes/no] : ");
            string userDecision = Console.ReadLine();

            while (userDecision.ToUpper() == "YES")
            {
                Console.Write("\nEnter Smart Device Name For Information : ");
                string userInput = Console.ReadLine();

                if (userInput.ToUpper() == "LIGHT")
                {
                    Console.WriteLine($"Name : {light.GetName()}");
                    Console.WriteLine($"Model : {light.GetModel()}");
                    Console.WriteLine($"Type : {light.GetType()}");
                    Console.WriteLine($"Brand Name : {light.GetBrandName()}");
                    Console.WriteLine($"Feature : {light.GetFeature()}");
                }
                else if (userInput.ToUpper() == "AC")
                {
                    Console.WriteLine($"Name : {ac.GetName()}");
                    Console.WriteLine($"Model : {ac.GetModel()}");
                    Console.WriteLine($"Type : {ac.GetType()}");
                    Console.WriteLine($"Brand Name : {ac.GetBrandName()}");
                    Console.WriteLine($"Feature : {ac.GetFeature()}");
                }
                else if (userInput.ToUpper() == "FAN")
                {
                    Console.WriteLine($"Name : {fan.GetName()}");
                    Console.WriteLine($"Model : {fan.GetModel()}");
                    Console.WriteLine($"Type : {fan.GetType()}");
                    Console.WriteLine($"Brand Name : {fan.GetBrandName()}");
                    Console.WriteLine($"Feature : {fan.GetFeature()}");
                }
                else if (userInput.ToUpper() == "DOOR")
                {
                    Console.WriteLine($"Name : {door.GetName()}");
                    Console.WriteLine($"Model : {door.GetModel()}");
                    Console.WriteLine($"Type : {door.GetType()}");
                    Console.WriteLine($"Brand Name : {door.GetBrandName()}");
                    Console.WriteLine($"\nFeature : {door.GetFeature()}");
                }
                else
                {
                    Console.WriteLine("You entered invalid device!");
                }

                Console.Write("Do you want to check another device....[yes/no] : ");
                userDecision = Console.ReadLine();
            }
            Console.WriteLine("Thank You For Staying With Us....");





        }
    }
}

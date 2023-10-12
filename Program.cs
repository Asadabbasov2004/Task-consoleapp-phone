using System.Diagnostics;
using System.Xml.Linq;

namespace task_consoleapp_phone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            Store store = new Store();
            while (check)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Do you want to add phone? ---1");
                Console.WriteLine("Do you want to show all  phone? ---2");
                Console.WriteLine("Do you want to remove phone in own list? ---3");
                Console.WriteLine("Do you want to search phone with price ? ---4");
                Console.WriteLine("Do you want to stop program? ---5");
                Console.WriteLine("\n");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("\n");
                        store.AddPhone();
                        Console.WriteLine("/////////////////////////////");
                        break;
                    case 2:
                        Console.WriteLine("\n");
                        store.Show();
                        Console.WriteLine("/////////////////////////////");
                        break;
                    case 3:
                        Console.WriteLine("\n");
                        store.RemovePhone();
                        Console.WriteLine("/////////////////////////////");

                        break;
                    case 4:
                        Console.WriteLine("\n");
                        store.ShowPhoneForPrice();
                        Console.WriteLine("/////////////////////////////");

                        break;
                    case 5:
                        Console.WriteLine("\n");
                        check = false;
                        Console.WriteLine("/////////////////////////////");

                        break;
                    default:
                        Console.WriteLine("\n");
                        Console.WriteLine("Please enter the correct number");
                        Console.WriteLine("/////////////////////////////");

                        break;
                }

            }
        }
    }
}
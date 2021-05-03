using System;
using System.IO;

namespace Assignment1
{
    class Program
    {
        public static void Main(string[] args)
        {
                Console.WriteLine("Welcome to Mahesh's Assignment");
                Console.WriteLine("Select the programme to RUN");
                Console.WriteLine("1. Rangoli");
                Console.WriteLine("2. Fibonaci");
                Console.WriteLine("3. Palendrome");

            int userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("You have selected \n 1. Rangoli");
                        Console.WriteLine("Executing programme");
                        Rangoli myobj = new ();
                    myobj.Assignment_1();
                        break;
                    case 2:
                        Console.WriteLine("You have selected 2. Fibonaci");
                        Console.WriteLine("Executing programme");
                    Fibonaci myobj_2 = new ();
                    myobj_2.Assignment_2();
                        break;
                    case 3:
                        Console.WriteLine("You have selected 3. Palendrome");
                        Console.WriteLine("Executing programme");
                    Palendrome myobj_3 = new ();
                    myobj_3.Assignment_3();
                        break;

                    default:
                        Console.WriteLine("You have entred a wrong option. Please try again");
                        break;
                }

        }
    }

}

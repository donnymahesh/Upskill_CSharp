using System;
using System.IO;

namespace Assignment1 
{
    
    public class Rangoli  
    {
        public void Assignment_1()
        {            
            Console.WriteLine("Enter the max number of start");
            int maxStar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max start entered is " + maxStar);
            
            for (int i = 1; i <= maxStar; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");

            }

            for (int i = maxStar; i >= 1; i--)
            {
                for (int j = 2; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");

            }

        }
    }
}

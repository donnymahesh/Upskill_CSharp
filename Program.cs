using System;

namespace Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the length of the series");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Series Length is " + length);
            Console.WriteLine("Enter the initial number of the series");
            int init_Num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Starting Fibonaci from " + init_Num);
            Console.Write(" " + init_Num);
            int sec_Num = init_Num + init_Num;
            Console.Write("." + sec_Num);

            {
                for (int i = 3; i <= length; i++)
                {
                    int next_Num = init_Num + sec_Num;
                   Console.Write("." + next_Num);
                    init_Num = sec_Num;
                    sec_Num = next_Num;

                }
            }
        }
    }
}

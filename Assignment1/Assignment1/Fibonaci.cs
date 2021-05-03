using System;

namespace Assignment1
{
    class Fibonaci
    {
        public void Assignment_2()
        {
            // Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the length of the series");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Series Length is " + length);
            // Console.WriteLine("Enter the initial number of the series");
            // int init_Num = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Starting Fibonaci from " + init_Num);
            // Console.Write(" " + init_Num);
             int init_Num = Convert.ToInt32(0);
            Console.Write("." + init_Num );
            int sec_Num = init_Num + init_Num;

            {
                for (int i = 3; i <= length ; i++)
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

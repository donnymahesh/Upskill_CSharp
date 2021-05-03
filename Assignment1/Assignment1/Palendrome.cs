using System;

namespace Assignment1
{
    class Palendrome
    {
        
            
        public void Assignment_3()
        {
            string enteredString, reverseString = string.Empty;
            Console.WriteLine("Enter a string to check for Palendrome!");
            enteredString = Console.ReadLine();
            Console.WriteLine("Entered string is " + enteredString);

            int length = enteredString.Length;
            Console.WriteLine("Entered string length is " + length);
            if (enteredString != null)
            {

                for (int i = length - 1; i >= 0; i--)
                {
                    reverseString += enteredString[i].ToString();
                }
                Console.WriteLine("Reverse of the string is " + reverseString);
                if (reverseString == enteredString)
                {
                    Console.WriteLine("Entered string is Palendrome since entered string {0} and reverse of the string {1} is same", enteredString, reverseString);
                }
                else
                {
                    Console.WriteLine("Entered string is not a Palendrome since entered string {0} and reverse of the string {1} DO NOT MATCH", enteredString, reverseString);
                }

            }
            else
            {
                Console.WriteLine("Null String detected");
            }
        }
     
    }
}

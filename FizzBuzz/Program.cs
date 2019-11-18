using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 101; i++)
            {
                // Makes sure its reset every time in the loop
                string Result = "";

                if (i % 7 == 0)
                {
                    Result += ("Bang");
                }
                if (i % 3 == 0 && i % 5 ==0)
                {
                    Result += ("FizzBuzz");
                }
                 else if (i % 3 == 0)
                {
                    Result += ("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Result += ("Buzz");
                }
                else if (i % 11 == 0)
                {
                    Result = "Bong";
                }
                else
                {
                    Result = i.ToString();
                }
                // Print the result to the console
                Console.WriteLine(Result);
            }
            // Just to keep the console open until a key is pressed
            Console.ReadLine();
        }
    }
}

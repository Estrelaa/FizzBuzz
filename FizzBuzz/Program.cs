using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 256; i++)
            {
                // Makes sure its reset every time in the loop
                string Result = "";
                
                
                if (i % 7 == 0)
                {
                    if (i % 13 == 0)
                    {
                        Result += "Fezz";
                    }
                    Result += "Bang";
                }
                if (i % 3 == 0 && i % 5 ==0)
                {
                    Result += "Fizz";
                    if (i % 13 == 0)
                    {
                        Result += "Fezz";
                    }
                    Result += "Buzz";
                }
                 else if (i % 3 == 0)
                {
                    Result += "Fizz";
                    if (i % 13 == 0)
                    {
                        Result += "Fezz";
                    }
                }
                else if (i % 5 == 0)
                {
                    if (i % 13 == 0)
                    {
                        Result += "Fezz";
                    }
                    Result += "Buzz";
                }
                else if (i % 11 == 0)
                {
                    if (i % 13 == 0)
                    {
                        Result += "Fezz";
                        Result += "Bong";
                    }
                    else
                    {
                        Result = "Bong";
                    }
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

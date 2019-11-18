using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaxValue = 0;
            List<string> Result = new List<string>();

            Console.WriteLine("Enter the max range: ");
            MaxValue = int.Parse(Console.ReadLine());

            for (int i = 0; i < MaxValue; i++)
            {
                // Makes sure Result resets every time in the loop
                Result.Clear();
                
                
                if (i % 7 == 0)
                {
                    if (i % 13 == 0)
                    {
                        Result.Add("Fezz");
                    }
                    Result.Add("Bang");
                }
                if (i % 3 == 0 && i % 5 ==0)
                {
                    Result.Add("Fizz");
                    if (i % 13 == 0)
                    {
                        Result.Add("Fezz");
                    }
                    Result.Add("Buzz");
                }
                 else if (i % 3 == 0)
                {
                    Result.Add("Fizz");
                    if (i % 13 == 0)
                    {
                        Result.Add("Fezz");
                    }
                }
                else if (i % 5 == 0)
                {
                    if (i % 13 == 0)
                    {
                        Result.Add("Fezz");
                    }
                    Result.Add("Buzz");
                }
                else if (i % 11 == 0)
                {
                    if (i % 13 == 0)
                    {
                        Result.Add("Fezz");
                        Result.Add("Bong");
                    }
                    else
                    {
                        Result.Add("Bong");
                    }
                }
                else
                {
                    Result.Add(i.ToString());
                }

                if (i % 17 == 0)
                {
                    Result.Reverse();
                }
                // Print the result to the console
                string Combined = string.Join("", Result);
                Console.WriteLine(Combined);
            }
            // Just to keep the console open until a key is pressed
            Console.ReadLine();
        }
    }
}

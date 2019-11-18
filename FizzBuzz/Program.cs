using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables need for the program to work
            int MaxValue = 0;
            List<string> Result = new List<string>();

            Console.WriteLine("Enter the max range: ");
            MaxValue = int.Parse(Console.ReadLine());

            for (int i = 0; i < MaxValue; i++)
            {
                // Makes sure Result resets every time in the loop
                Result.Clear();
                               
             
                if (i % 3 == 0 && i % 5 ==0)
                {
                    Result.Add("Fizz");
                    Fezz(Result, i);
                    Result.Add("Buzz");
                }
                 else if (i % 3 == 0)
                {
                    Result.Add("Fizz");
                    Fezz(Result, i);
                }
                else if (i % 5 == 0)
                {
                    Fezz(Result, i);
                    Result.Add("Buzz");
                }
                if (i % 7 == 0)
                {
                    Fezz(Result, i);
                    Result.Add("Bang");
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
                if (i % 17 == 0)
                {
                    Result.Reverse();
                }
                else
                {
                    Result.Add(i.ToString());
                }

                // Print the result to the console
                string Combined = string.Join("", Result);
                Console.WriteLine(Combined);
            }
            // Just to keep the console open until a key is pressed
            Console.ReadLine();
        }

        private static List<string> Fezz(List<string> Result, int i)
        {

            if (i % 13 == 0)
            {
                foreach (string word in Result)
                {
                    if (word == "Buzz" | word == "Bang")
                    {

                    }
                }
               
            }
            return Result;
        }
    }
}

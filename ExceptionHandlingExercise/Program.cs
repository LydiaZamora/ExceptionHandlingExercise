using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var arr = new char[] { '3', '4', '1', '2', '8', '9','a', 'b', 'c'};


            var numbers = new List<int>();

            string str = "";
           

            foreach(var character in arr)
            {
                Console.WriteLine(character);
                try
                {
                    str = character.ToString();
                    int number = int.Parse(str);
                    numbers.Add(number);
                }

                catch(Exception e)
                {
                    Console.WriteLine($"Unable to Parse '{character}'");
                }
            }
                                          
            
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}

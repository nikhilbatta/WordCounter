using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
            Calculation.userInputToList("I am a dog");
            foreach(string item in Calculation.AuthorList)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
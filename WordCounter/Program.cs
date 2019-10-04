using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
            Calculation.userInputToList("dog", "I am a dog doghead dog");
            // foreach(string item in Calculation.AuthorList)
            // {
            //     Console.WriteLine(item);
            // }
            
        }
        public static void StartWordCounter()
        {
            Console.WriteLine("please enter in a sentence");
            string userFirstAnswer = Console.ReadLine();
            Console.WriteLine("Please enter in a word that you would like to find in the sentence ");

        }
    }
}
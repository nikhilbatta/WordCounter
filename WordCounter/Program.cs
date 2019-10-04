using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
            // Calculation.userInputToList("dog", "I am a dog doghead dog");
            // foreach(string item in Calculation.AuthorList)
            // {
            //     Console.WriteLine(item);
            // }
            StartWordCounter();
            
        }
        public static void StartWordCounter()
        {
            Console.WriteLine("Please enter in a word that you would like to find in the sentence ");
            string userFirstAnswer = Console.ReadLine();
            char[] errorChecker = userFirstAnswer.ToCharArray();
            foreach(char error in errorChecker)
            {
                if(Char.IsPunctuation(error))
                {
                    Console.WriteLine("please enter in a valid word");
                    StartWordCounter();
                }
            }
            Console.WriteLine("please enter in a sentence");
            string userSecondAnswer = Console.ReadLine();
           
            Console.WriteLine(Calculation.userStringToCounter(userFirstAnswer,userSecondAnswer));

        }
    }
}
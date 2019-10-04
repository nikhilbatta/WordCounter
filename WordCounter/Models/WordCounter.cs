using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class Calculation
    {
        // public static List<string> AuthorList = new List<string>();  
        
        public static void userInputToList(string userInput)
        {
            string [] stringList = userInput.Split(" ");
            foreach(string ok in stringList)
            {
                int counter = 0;
                if (ok == "dog")
                {
                    counter++;
                    Console.WriteLine(counter);
                }
            }
           
        }
    }
}
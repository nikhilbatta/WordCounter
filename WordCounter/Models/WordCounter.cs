using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class Calculation
    {
        // public static List<string> AuthorList = new List<string>();  
        
        public static void userInputToStringArray(string whatitshouldbe, string userInput)
        {
            string [] stringList = userInput.Split(" ");
            stringArrayCounter(stringList)
           
        }
        public static int stringArrayCounter(string[] stringList)
        {
             int counter = 0;
            foreach(string ok in stringList)
            {
                
                if (ok == whatitshouldbe)
                {
                    counter++;
                }
            }
                Console.WriteLine(counter);
        }
    }
}
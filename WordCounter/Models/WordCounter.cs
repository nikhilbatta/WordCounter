using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class Calculation
    {
        // public static List<string> AuthorList = new List<string>();  
        
        public static int userInputToStringArray(string whatitshouldbe, string userInput)
        {
            string [] stringList = userInput.ToLower().Split(" ");
            int counter = 0;
            foreach(string ok in stringList)
            {
                if (ok == whatitshouldbe)
                {
                    counter++;
                }
            }  
           return counter;
        }
        
        
    }
}
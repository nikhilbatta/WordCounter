using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class Calculation
    {
        // public static List<string> AuthorList = new List<string>();  
        
        public static int userStringToCounter(string whatitshouldbe, string userInputSentence)
        {
            string [] stringList = userInputSentence.ToLower().Split(" ");
            int counter = 0;
            foreach(string singleword in stringList)
            {
                if (singleword == whatitshouldbe)
                {
                    counter++;
                }
            }  
           return counter;
        }
        
        
    }
}
using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
            
            string word = Calculation.GrabWord(); 
            string sentence = Calculation.GrabSentence(); 
            int counter = Calculation.userStringToCounter(word,sentence);
            Console.WriteLine(counter);
        }
        
    }
}
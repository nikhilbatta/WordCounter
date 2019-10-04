using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
            string word = RepeatCounter.GrabWord(); 
            string sentence = RepeatCounter.GrabSentence(); 
            int counter = RepeatCounter.userStringToCounter(word,sentence);
            if(counter > 0)
            {
                Console.WriteLine("Your word appeared this many times:" + counter);
            }
            else
            {
                Console.WriteLine("Couldn't find your word")
            }
        }
        
    }
}
using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class Calculation
    {
        public static dynamic GrabWord()
        {
            Console.WriteLine("Please enter in a word that you would like to find in the sentence ");
            string userFirstAnswer = Console.ReadLine();
            char[] errorChecker = userFirstAnswer.ToCharArray();
            foreach(char error in errorChecker)
            {
                if(Char.IsPunctuation(error))
                {
                    
                    return GrabWord();
                    
                }
            }
            Console.WriteLine(userFirstAnswer);
            return GrabSentence(userFirstAnswer);
        }
        public static int GrabSentence(string userFirstAnswer)
        {
            
            Console.WriteLine("please enter in a sentence");
            string userSecondAnswer = Console.ReadLine();
            char[] secondAnswerErrorChecker = userSecondAnswer.ToCharArray();
            foreach(char error1 in secondAnswerErrorChecker)
            {
                if(Char.IsPunctuation(error1))
                {
                    Console.WriteLine("please enter in a valid sentence");
                    GrabSentence(userFirstAnswer);
                }
            }
            Console.WriteLine(userFirstAnswer);
            int counter = Calculation.userStringToCounter(userFirstAnswer,userSecondAnswer);
            return counter;

        }
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
            Console.WriteLine(counter);  
           return counter;
        }
        
        
    }
}
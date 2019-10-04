using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class Calculation
    {
       
        public static string GrabWord()
        {
            Console.WriteLine("Please enter in a word that you would like to find in the sentence r ");
            string userFirstAnswer = Console.ReadLine();
            bool isError = false;
            char[] errorChecker = userFirstAnswer.ToCharArray();
            foreach(char error in errorChecker)
            {
                if(Char.IsPunctuation(error))
                {
                   isError = true;
                }
            }
            if(isError)
            {
                return GrabWord();
            }
            else
            {
                  return userFirstAnswer;
            }
        }
        public static string GrabSentence()
        {
            Console.WriteLine("please enter in a sentence");
            string userSecondAnswer = Console.ReadLine();
            bool isError = false;
            char[] secondAnswerErrorChecker = userSecondAnswer.ToCharArray();
            foreach(char error1 in secondAnswerErrorChecker)
            {
                if(Char.IsPunctuation(error1))
                {
                    isError =true;
                }
            }
            if(isError)
            {
                return GrabSentence();
            }
            else
            {
                return userSecondAnswer;
            }
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
           return counter;
        }
    }
}
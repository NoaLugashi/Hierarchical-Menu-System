using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class CountLowercase : IMethodItemSelectedListener
    {
        void IMethodItemSelectedListener.MethodSelected()
        {
            CountLowercaseLetters();
        }

        public static void CountLowercaseLetters()
        {
            string userInput;
            int lowercaseLetterCount = 0;

            userInput = Console.ReadLine();

            foreach (char letter in userInput)
            {
                if (char.IsLower(letter)) 
                {
                    lowercaseLetterCount++;
                }
            }

            if (lowercaseLetterCount == 0)
            {
                Console.WriteLine("> There are no lowercase letters in your text.");
            }
            else if (lowercaseLetterCount == 1)
            {
                Console.WriteLine("> There is {0} lowercase letter in your text.", lowercaseLetterCount);
            }
            else
            {
                Console.WriteLine("> There are {0} lowercase letters in your text.", lowercaseLetterCount);
            }
        }
    }
}
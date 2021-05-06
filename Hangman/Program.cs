using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                     WELCOME to HANGMAN");


            string mysteryWord = "";
            bool exit = false;


            Console.WriteLine("Please Enter a Word: ");
            mysteryWord = Console.ReadLine().ToLower();
            Console.Clear();




            string tempWord = "";
            foreach (char c in mysteryWord)
            {
                tempWord += ("_");
            }
            Console.WriteLine(tempWord);




            if (mysteryWord == "exit".ToLower())
            {
                exit = true;
            }

            if (exit == true)
            {
                System.Environment.Exit(0);
            }



            int guesscount = 0;
            bool guess = false;
            int correctguess = 0;
            string letterentered = "";
            char letter;
            bool checkletter = false;

            while (guesscount <= 6 && guess == false)
            {
                Console.WriteLine("You have made " + guesscount + "incorrect guesses");
                checkletter = false;
                Console.WriteLine(tempWord);
                Console.Write("Guess a letter: ");
                letter = Convert.ToChar(Console.ReadLine().ToLower());
            }



            int index = 0;


            foreach (char c in mysteryWord)
            {
                if (c == letter)
                {
                    checkletter = true;
                    correctguess++;
                    StringBuilder sb = new StringBuilder(tempWord);
                    sb[index] = letter;
                    tempWord = sb.ToString();
                }

                index++;


            }





            if (correctguess == mysteryWord.Length)
            {
                guess = true;
            }

            if (checkletter == false)
            {
                guesscount++;
                letterentered += letter;
                Console.WriteLine("Your incorrect guesses: " + letterentered);
            }
        }
    }
}

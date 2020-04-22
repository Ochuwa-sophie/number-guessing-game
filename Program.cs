﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace numberguessing
{
    class Program
    {
        static void Main(string[] args)
        { 
            int correctNumber1 = 7;
            int correctNumber2 = 13;
            int correctNumber3 = 39;
            int userGuess = 0;
            int numberOfTrials = 0;
            

            Console.Write("Choose a level, 1 for Easy,2 for Medium, 3 for Hard : ");
            int level = int.Parse(Console.ReadLine());
            if (level == 1)
            {
            while (userGuess != correctNumber1)
        {
                Console.Write("It is a number between 1 and 10, What is your guess : ");
                int.TryParse(Console.ReadLine(), out userGuess );

                if(userGuess > correctNumber1 || userGuess < correctNumber1)
                {
                    Console.WriteLine("That was wrong! You have " + numberOfTrials + "guesses left", userGuess);
                }
                
                else
                {
                     Console.WriteLine("You got it right!", userGuess);
                }
        }

        }
            else if (level == 2)
            {
            while (userGuess != correctNumber2)
        {
                Console.Write("It is a number between 1 and 20, What is your guess : ");
                int.TryParse(Console.ReadLine(), out userGuess );

                if(userGuess > correctNumber2 || userGuess < correctNumber2)
                {
                    Console.WriteLine("That was wrong, you have " + numberOfTrials + " guesses left.", userGuess);
                }
               
                else
                {
                     Console.WriteLine("You got it right!", userGuess);
                }
        }

        }

         else if (level == 3)
            {
            while (userGuess != correctNumber3)
        {
                Console.Write("It is a number between 1 and 50, What is your guess : ");
                int.TryParse(Console.ReadLine(), out userGuess );

                if(userGuess > correctNumber3 || userGuess < correctNumber3)
                {
                    Console.WriteLine("That was wrong, you have " + numberOfTrials + "guesses left.", userGuess);
                }
              
                else
                {
                     Console.WriteLine("You got it right!", userGuess);
                }
        }

        }
        }
    }
}    
using System;
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
            
            
            

            Console.Write("Choose a level, 1 for Easy,2 for Medium, 3 for Hard : ");
            int level = int.Parse(Console.ReadLine());
            if (level == 1)
            {
            List<int> numberOfTrials = new List<int> ();
            for (int i = 6; i < 7; i-- )
            {
               int userGuess = 0;
                
            while (userGuess != correctNumber1)
            {
               
                Console.Write("It is a number between 1 and 10, What is your guess : ");
                int.TryParse(Console.ReadLine(), out userGuess );

                if(i > correctNumber1 || userGuess < correctNumber1)
                {
                    Console.WriteLine("That was wrong! You have " + i + "guesses left", userGuess);
                }
            
                else
                {
                     Console.WriteLine("You got it right!", userGuess);
                }
                }
                if (numberOfTrials [i] == 6)
                {
                    Console.WriteLine("Game Over");
                }
                }
                
               
            }
            else if(level == 2)
            {
                 List<string> numberOfTrials2 = new List<string> ();
            for (int i = 0; i < 5; i++ )
            {

                
			 {
            while (i != correctNumber2)
        {
               
                Console.Write("It is a number between 1 and 20, What is your guess : ");
                int.TryParse(Console.ReadLine(), out i );

                if(i > correctNumber2 || i < correctNumber2)
                {
                    Console.WriteLine("That was wrong, you have " + i + " guesses left.", i);
                }
               
                else
                {
                     Console.WriteLine("You got it right!", i);
                }

            }
             }
            }
            Console.WriteLine("Game Over");
            }
            
            else if (level == 3)
         
			 {
            {
                List<string> numberOfTrials = new List<string> ();
            for (int i = 0; i < 7; i++ )
            {
               
                
                 while (i != correctNumber3)
        {
               
            
                Console.Write("It is a number between 1 and 50, What is your guess : ");
                int.TryParse(Console.ReadLine(), out i );


                if(i > correctNumber3 || i < correctNumber3)
                {
                    Console.WriteLine("That was wrong, you have " + i + "guesses left.", i);
                }
              
                else
                {
                     Console.WriteLine("You got it right!", i);
                }
        }
        }

        }
        }
            

        } 
           
    }
}
           
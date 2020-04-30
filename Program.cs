using System;

namespace numberguessing
{
    class Program
    {
        static void Main(string[] args)
        { 
          
            Console.Write("Choose a level, 1 for Easy,2 for Medium, 3 for Hard : ");
            int level = int.Parse(Console.ReadLine());

            if (level == 1)
            {
                try {
                    Random random = new Random ();  
                    int randomNumber = random.Next (1, 11);
                    int guess = 0;
                    int numberOfGuess = 6;
                    bool gameOver = false;

                    Console.WriteLine (" Easy mode: It is a number between 1 and 10, What is your guess : ");    

                    while (gameOver == false) {
                        guess = Convert.ToInt32 (Console.ReadLine ());
                        numberOfGuess--;

                        if (guess != randomNumber && numberOfGuess == 0) 
                        {
                            Console.WriteLine ("You've used up Your 6 Guess chances....GAME OVER!!");
                            gameOver = true;
                        } 
                            else if (guess == randomNumber) 
                        {
                            Console.WriteLine ("YOU WIN");
                            gameOver = true;
                        }   
                            else if (guess > randomNumber) 
                        {
                            Console.WriteLine ("Number too high ,  Go low!");
                        }  
                             else if (guess < randomNumber) 
                        {
                            Console.WriteLine ("Number too low ,  Go high!");
                        }

                                              
                            Console.ReadLine ();
                    }
                        }   catch (FormatException) {
                    Console.WriteLine ("Wrong Input... PLEASE ENTER A NUMBER.");
                                                    }
            }

               
            else if(level == 2)
            {
                try {
                        Random random = new Random ();  
                        int randomNumber = random.Next (1, 21);
                        int guess = 0;
                        int numberOfGuess = 4;
                        bool gameOver = false;

                        Console.WriteLine (" Easy mode: It is a number between 1 and 20, What is your guess : ");    

                        while (gameOver == false) 
                    {
                        guess = Convert.ToInt32 (Console.ReadLine ());
                        numberOfGuess--;

                        if (guess != randomNumber && numberOfGuess == 0) 
                    {
                            Console.WriteLine ("You've used up Your 4 Guess chances....GAME OVER!!");
                            gameOver = true;
                    }   
                        else if (guess == randomNumber)
                    {
                            Console.WriteLine ("YOU WIN");
                            gameOver = true;
                    } 
                        else if (guess > randomNumber) 
                    {
                            Console.WriteLine ("Number too high ,  Go low!");
                    }   
                        else if (guess < randomNumber) 
                    {
                            Console.WriteLine ("Number too low ,  Go high!");
                    }

                    }
                            Console.ReadLine ();
                    }   
                        catch (FormatException) 
                    {
                        Console.WriteLine ("Wrong Input... PLEASE ENTER A NUMBER.");
                    }
                
            }
            else if (level == 3)
         
		{
            try 
        {
                Random random = new Random ();  
                int randomNumber = random.Next (1, 51);
                int guess = 0;
                int numberOfGuess = 3;
                bool gameOver = false;

                    Console.WriteLine (" Easy mode: It is a number between 1 and 50, What is your guess : ");    

            while (gameOver == false) 
        {
                guess = Convert.ToInt32 (Console.ReadLine ());
                numberOfGuess--;

                if (guess != randomNumber && numberOfGuess == 0) 
        {
                Console.WriteLine ("You've used up Your 6 Guess chances....GAME OVER!!");
                gameOver = true;
        }       
                else if (guess == randomNumber) 
        {
                Console.WriteLine ("YOU WIN");
                gameOver = true;
        } 
                else if (guess > randomNumber) 
        {
                Console.WriteLine ("Number too high ,  Go low!");
                Console.ReadLine ();
        } 
                else if (guess < randomNumber) 
        {
                Console.WriteLine ("Number too low ,  Go high!");
                Console.ReadLine ();
        }
 
        }
        }      
                catch (FormatException) 
        {
                    Console.WriteLine ("Wrong Input... PLEASE ENTER A NUMBER.");
        }
        }
              
            else 
            {
                Console.WriteLine("Please press enter and play the game again." );
                Console.ReadKey();
            }

        } 
           
    }
}

           
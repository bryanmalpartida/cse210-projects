using System;

class Program
{
    static void Main(string[] args)
    {
        //IMPORT
        Random randomGenerator = new Random();
        //VARIABLES
        //magic number is random
        int magicNumber = randomGenerator.Next(1, 101);
        //guess variables
        int guess = -1;
        int guesscount = 0;
        //LOOP
        while (guess != magicNumber)
        {
            guesscount++;

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
        //CONDITIONALS AND PRINTING
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        //NUMBER OF GUESSES PRINT
        Console.WriteLine($"It took you {guesscount} guesses. ");                    
    
    }
}
using System;

namespace Tutorial_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string guessWord = "GUESS";
            string guess = "";

            int guessCount = 1;
            int guessLimit = 4;
            bool outOfGuesses = false;

            while(guess != guessWord.ToLower() && !outOfGuesses)
            {
                if(guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    Console.WriteLine("You have used " +guessCount+" from your 3 guess (guess is 5 letters)");
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.WriteLine("YOU LOSE !");
            }
            else
            {
            Console.WriteLine("YOU WIN !!!");
            }

            Console.ReadLine();
        }
    }
}

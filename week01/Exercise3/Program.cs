using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain;
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 11);
            int response;
            int guesses = 0;
            do
            {
                Console.Write("What is the magic number?");
                string responseString = Console.ReadLine();
                response = int.Parse(responseString);
                if (response < magicNumber)
                {
                    Console.WriteLine("Too low!");
                }
                else if (response > magicNumber)
                {
                    Console.WriteLine("Too high!");
                }
                guesses++;
            } while (response != magicNumber);
            Console.WriteLine("You guessed it!");
            Console.WriteLine("It took you " + guesses + " guesses.");
            Console.Write("Do you want to play again? (y/n) ");
            string playAgainString = Console.ReadLine();
            playAgain = playAgainString == "y";
        } while (playAgain);
    }
}
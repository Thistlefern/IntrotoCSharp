using System;
/// <summary>
/// An Unimaginative Guess the number engine
/// Deliberatly dumb.
/// With some deliberate logic
/// </summary>
namespace GuessTheNumber
{
    class Program
    {
        /// <summary>
        /// Main is your programs entrypoint, for most purposes you should
        /// regard it as being the first piece of code in your program that will be executed.
        /// (this is almost 99% true, and is good enough for now.)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int g = 1; g < 1000; g++)
            {

                Random nGenerator = new Random();
                //Some error trapping
                if (args.Length == 0)
                {
                    Console.WriteLine("GuessTheNumber requires 2 parameters the first is the number of guesses, the second is the max number I pick from.");
                    return;
                }

                int numberOfTries = int.Parse(args[0]);
                int ceiling = int.Parse(args[1]);


                int myNumber = nGenerator.Next(ceiling);
                int playerGuessNum = 0;
                Console.WriteLine($"Game number {g}.");
                Console.WriteLine($"I am thinking of a whole number between 0 and {ceiling}");
                Console.WriteLine($"Can you try and guess it in less than {numberOfTries} tries ?");

                for (int i = numberOfTries; i > 0 && playerGuessNum != myNumber; i--)
                {
                    Console.WriteLine("You have " + i.ToString() + " tries left.");
                    Console.WriteLine("Take a guess!");
                    string playerGuess = Console.ReadLine();
                    playerGuessNum = int.Parse(playerGuess);
                    if (playerGuessNum > myNumber)
                    {
                        Console.WriteLine("Too High, try again.");
                    }
                    else if (playerGuessNum < myNumber)
                    {
                        Console.WriteLine("Too Low, try again.");
                    }
                    else if (playerGuessNum == myNumber)
                    {
                        Console.WriteLine($"Well Done. You took {numberOfTries - i + 1} attempts.");
                    }
                    else
                    {
                        Console.WriteLine("Too bad you didn't guess it, I'm just too smart.");
                    }
                }
                Console.WriteLine("Play again? Press Enter!");
                Console.ReadKey();
                Console.WriteLine("\n");
            }
        }
    }
}

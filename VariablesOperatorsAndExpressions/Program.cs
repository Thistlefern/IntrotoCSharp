using System;

namespace VariablesOperatorsAndExpressions
{
    class Program
    {
        static void Main()
        {
            string greeting = "Hello, user! The game's start condition is: ";
            bool gameStarted = false;
            string displayGameState = greeting + gameStarted;
            Console.WriteLine(displayGameState);

            gameStarted = true;
            displayGameState = greeting + gameStarted;
            Console.WriteLine(displayGameState);
            Console.ReadKey();

        }
    }
}

﻿using System;

namespace IfStatements
{
    class Program
    {
        static void Main()
        {
            int score = 0;
            int combo = 1;
            int pointValue = 100;
            bool gameStarted = false;
            if (score == 0)
            {
                gameStarted = true;
                if (gameStarted)
                {
                    score = combo * pointValue;
                    combo++;
                    Console.WriteLine("You got a combo! Your new score is: " + score);
                    Console.ReadKey();
                }
            }
        }
    }
}
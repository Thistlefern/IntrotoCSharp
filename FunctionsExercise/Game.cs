using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionsExercise
{
    class Game
    {
        public int score = 0;
        public void Start()
        {
            Console.WriteLine($"Your starting score was {score}.");
            Console.WriteLine($"You scored! Your score is now {AddToScore(10)}.");
            Console.WriteLine($"You scored! Your score is now {AddToScore(25)}.");
            Console.WriteLine($"You scored! Your score is now {AddToScore(5)}.");
        }
        public int AddToScore(int add)
        {
            score += add;
            return score;
        }

        public int PrintScore(int add)
        {
            Console.WriteLine($"You scored! Your score is now {PrintScore(20)}");
            Console.WriteLine($"You scored! Your score is now {PrintScore(30)}");
            Console.WriteLine($"You scored! Your score is now {PrintScore(40)}");
            return score;
        }
    }
}

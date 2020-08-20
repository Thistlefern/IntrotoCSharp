using System;

namespace LoopsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int score = 0;

            while (a < 100)
            {
                a += 10;
                b++;
                Console.WriteLine($"Your progress: {a}% complete. This code has run {b} time(s).\n");
                
            }
           
            for (c=1; c<20; c++)
            {
                Console.WriteLine($"Woof! That's {c} bark(s)...Your score is {score}."); //Added score to make sure it was working.
                // The above won't break since it never goes over 100, but wanted to make sure it worked.
                if (score < 100)
                {
                    score += 20;
                    
                } else if(score > 100) {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace IfStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playerAlive = true;
            if (playerAlive = true)
            {
                Console.WriteLine("You are still alive.");
            } else
            {
                Console.WriteLine("You are dead.");
            }
            int invulerabilityTimer = 10;
            invulerabilityTimer -= 11;

            if (invulerabilityTimer > 0)
            {
                Console.WriteLine("You are invulnerable!");
                if (playerAlive = true)
                {
                    invulerabilityTimer--;
                }
            } else if (invulerabilityTimer == 0)
            {
                Console.WriteLine("You are now able to take damage. Be careful!");
            } else
            {
                invulerabilityTimer = 0;
                Console.WriteLine("You are now able to take damage. Be careful!");
            }

        }
    }
}

//9. Finally, inside your if statement where you check to see if invulnerabilityTimer is greater
//than 0, nest another if statement. Set the condition to check if playerAlive has a value of
//true. If it does, subtract a value of 1 from invulnerabilityTimer.
//Try changing how much gets subtracted from invulnerabilityTimer in step 5 to see how it affects the
//way your program runs.

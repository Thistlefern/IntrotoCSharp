using System;

namespace FunctionsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Game newGame = new Game();
            newGame.score = 100;

            newGame.Start();

//9. In the Start function of your game class, on a new line
//a.Print out text telling the player they scored, and then print out their score.
//b.Instead of printing out the value of the score variable directly, insert the
//AddToScore function and pass in how much you want to increase the score by, so
//that you can increase the score and display the new value at the same time
//10. On a new line, do the same thing you just did but increase the score by a different value
//11. Repeat that process one more time, increasing the score again and printing out the value
//12. Create a new function called PrintScore
//a.Create a temporary int called add in the parentheses, also called passing in a
//variable
//b.Copy and paste the text you used earlier for printing the players score, and insert it
//into this function.
//c.Replace the value you used to increase the score by with the new temporary int add
//from the PrintScore function
//13. Replace the code you copy and pasted earlier for printing the score and replace it by using
//this function 3 times, passing in different values
//This process of quickly getting the code to work by copy and pasting, then once it works and
//seeing where code is repeated, creating functions to replace that repeated code, is a useful
//process.
//a.First focus on quickly making something work
//b. Test it
//c.Then look for areas of code that are messy and could be cleaned up or areas of code
//that are repeated and see if a function can replace repeated code.
//Leaving repeated code, or leaving code that has been copy and pasted multiple times, is bad
//practice. Always replace repeated code with functions. You can see how much easier it will
//be to change the code now if we wanted to do something different when we printed the
//score or added to the score.
//But doing some quick copy and pasting to make something work initially is okay, so long as it
//doesn’t stay that way. Always aim for clean code. It will make your life as a programmer
//easier in the long run.
        }
    }
}

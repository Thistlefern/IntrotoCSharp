using System;

namespace IfStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

//Create a new C# console project in Visual Studio called IfStatementsExercise.
//Add the following code to the Main function:
//1.Create a bool called playerAlive, and initialise it’s value to true.
//2. Afterwards, create an if statement that checks to see if the playerAlive variable is true. If it
//is, print out some text telling the player they’re still alive.
//3. Create an else statement after it. Inside it, print text telling the player they are dead.
//4. Create a new int called invulnerabilityTimer, and set it’s value to something greater than 0.
//5. On the next line, subtract some value from your invulnerabilityTimer variable
//6. Create a new if statement, and for the condition, check to see if invulnerabilityTimer is
//greater than 0.If it is, print out text telling the player they are invulnerable.
//7. Create an else if statement after the if statement, and set the condition to check if
//invulnerabilityTimer is equal to 0. If it is, print text telling the player they are now
//vulnerable to damage.
//8. Create another else if statement after that, and set the condition to check if
//invulnerabilityTimer is less than 0. If it is, set the value of invulnerabilityTimer back to 0.
//9. Finally, inside your if statement where you check to see if invulnerabilityTimer is greater
//than 0, nest another if statement. Set the condition to check if playerAlive has a value of
//true. If it does, subtract a value of 1 from invulnerabilityTimer.
//Try changing how much gets subtracted from invulnerabilityTimer in step 5 to see how it affects the
//way your program runs.

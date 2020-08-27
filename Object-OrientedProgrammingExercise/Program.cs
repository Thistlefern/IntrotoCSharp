using System;

namespace Object_OrientedProgrammingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // introduction text
            Console.WriteLine("Welcome to the Zombie Arena!");

            // controls whether or not the battle should continue
            bool isBattleOver = false;

            // here is where the player is added, so they can be used in the battle loop
            Player player = new Player();
            int numberOfPotions = 2;

            // here is where a zombie is added
            Zombie zombie = new Zombie();

            // battle loop
            while (isBattleOver != true)
            {
                // prompt for user input
                Console.WriteLine("\nWhat would you like to do?");
                string playerInput = Console.ReadLine();
                playerInput = playerInput.ToLower();
                Console.WriteLine("\n");

                // player input list
                switch (playerInput)
                {
                    // TODO add more commands
                    //case "":
                    //    Console.WriteLine("");
                    //    break;

                    // player can quit
                    case "quit":
                        isBattleOver = true;
                        break;
                    
                    // player can ask for help
                    case "help":
                        Console.WriteLine("Sure, I can help you! Try commands like checking your bag, checking your health, or attacking. If you want to leave the game, simply type quit.");
                        break;

                    case "die":
                        Console.WriteLine("Well, you've got a weapon! You fall on your sword.");
                        isBattleOver = true;
                        break;

                    case "check health":
                        Console.WriteLine($"You health is currently at {player.healthPoints} points");
                        break;

                    case "am i alive":
                        Console.WriteLine("I mean...you wouldn't be asking if you weren't alive, now would you?");
                        break;

                    case "joke":
                        Console.WriteLine("You saw how well that went for Terry. The zombie bites you, you fool!");
                        player.healthPoints -= 20;
                        Console.WriteLine($"You lost 20 health, and are now at {player.healthPoints} health points.");
                        break;

                    case "check bag":
                        if (numberOfPotions == 0)
                        {
                            Console.WriteLine($"Oh yeah, you have one of those don't you? Let's see...some snacks, a few rocks, and...that's it.");
                        }
                        else if (numberOfPotions == 1)
                        {
                            Console.WriteLine($"Oh yeah, you have one of those don't you? Let's see...some snacks, a few rocks, and {numberOfPotions} health potion.");
                        } else
                        {
                            Console.WriteLine($"Oh yeah, you have one of those don't you? Let's see...some snacks, a few rocks, and {numberOfPotions} health potions.");
                        }
                        break;

                    case "drink potion":
                        if(numberOfPotions != 0)
                        {
                            Console.WriteLine("You take a potion from your bag and drink it. It restores 20 of your health points!");
                            player.healthPoints += 20;
                            if (player.healthPoints > 100)
                            {
                                player.healthPoints = 100;
                            }
                            Console.WriteLine($"You now have {player.healthPoints} health points.");
                            numberOfPotions--;
                        } else
                        {
                            Console.WriteLine("You can't do that, you don't have any potions!");
                        }
                        break;

                    // player can attack
                    case "attack":
                        Console.WriteLine("You attack a zombie!");
                        player.Attack(10);
                        // TODO adjust later
                        zombie.TakeDamage(10);
                        // TODO adjust later
                        Console.WriteLine($"The zombie took 10 damage, and has {zombie.healthPoints} health points left.");
                        if (zombie.healthPoints <= 0)
                        {
                            Console.WriteLine("The zombie has been killed! There are still more to attack, if you want!");
                        }
                        else
                        {
                            Console.WriteLine("\nThe zombie attacks you back!");
                            zombie.Attack(10);
                            player.TakeDamge(10);
                            Console.WriteLine($"You took 10 damage, and have {player.healthPoints} health points left.");
                            if(player.healthPoints <= 0)
                            {
                                Console.WriteLine("You have been killed! Your game is over...");
                                isBattleOver = true;
                            }
                        }

                        break;

                    // default
                    default:
                        Console.WriteLine("That isn't a known command. Try something else!");
                        break;
                }

            }
            // game finished text
            Console.WriteLine("\nThank you for playing! Press ENTER to exit the game.");
            Console.ReadLine();
        }
    }
}

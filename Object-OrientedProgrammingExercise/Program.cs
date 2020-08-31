using System;

namespace Object_OrientedProgrammingExercise
{
    class Program
    {
        static void Main()
        {
            // introduction text
            Console.WriteLine("Welcome to the Zombie Arena!");
            int numberOfPotions = 2;
            // here is where the player is added, so they can be used in the battle loop
            Player player = new Player();
            player.health = 100;

            for (int g = 1; g < 101; g++)
            {
                Random random = new Random();
                int newEnemy = random.Next(25);

                // controls whether or not the battle should continue
                bool isBattleOver = false;

                // here is where zombies are added
                Zombie zombie = new Zombie();
                if(newEnemy == 25)
                {
                    zombie = new Boss();
                    zombie.defense = 0.25;
                    zombie.attack = 15;
                    zombie.health = 100;
                    Console.WriteLine("A GIANT zombie approaches you! It's a boss fight!");
                }
                else if (newEnemy <=24 && newEnemy >= 19)
                {
                    zombie = new ArmedZombie();
                    zombie.attack = 15;
                    Console.WriteLine("A zombie with a sword approaches you!");
                }
                else if (newEnemy <= 18 && newEnemy >= 13)
                {
                    zombie = new ArmedZombie();
                    zombie.defense = 0.25;
                    Console.WriteLine("A zombie in armor approaches you!");
                }
                else
                {
                    Console.WriteLine("A zombie approaches you!");
                }
                    
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
                            Console.WriteLine($"Thank you for playing!\nYou killed {g} zombies this game.\nPress ENTER twice to exit the game.");
                            Console.ReadKey();
                            return;

                        // player can ask for help
                        case "help":
                            Console.WriteLine("Sure, I can help you! Try commands like checking your bag, checking your health, or attacking. If you want to leave the game, simply type quit.");
                            break;

                        case "die":
                            Console.WriteLine("Well, you've got a weapon! You fall on your sword.");
                            isBattleOver = true;
                            break;
                        case "be devoured":
                            Console.WriteLine("The zombie eats you!");
                            player.TakeDamage(1000);
                            break;

                        case "check health":
                            Console.WriteLine($"You health is currently at {player.health} points");
                            break;

                        case "am i alive":
                            Console.WriteLine("I mean...you wouldn't be asking if you weren't alive, now would you?");
                            break;

                        case "joke":
                            Console.WriteLine("You saw how well that went for Terry. The zombie bites you, you fool!");
                            player.TakeDamage(20);
                            Console.WriteLine($"You lost 20 health, and are now at {player.health} health points.");
                            break;

                        case "check bag":
                            if (numberOfPotions == 0)
                            {
                                Console.WriteLine($"Oh yeah, you have one of those don't you? Let's see...some snacks, a few rocks, and...that's it.");
                            }
                            else if (numberOfPotions == 1)
                            {
                                Console.WriteLine($"Oh yeah, you have one of those don't you? Let's see...some snacks, a few rocks, and {numberOfPotions} health potion.");
                            }
                            else
                            {
                                Console.WriteLine($"Oh yeah, you have one of those don't you? Let's see...some snacks, a few rocks, and {numberOfPotions} health potions.");
                            }
                            break;

                        case "drink potion":
                            if (numberOfPotions != 0)
                            {
                                Console.WriteLine("You take a potion from your bag and drink it. It restores 20 of your health points!");
                                player.health += 20;
                                if (player.health > 100)
                                {
                                    player.health = 100;
                                }
                                Console.WriteLine($"You now have {player.health} health points.");
                                numberOfPotions--;
                            }
                            else
                            {
                                Console.WriteLine("You can't do that, you don't have any potions!");
                            }
                            break;

                        // player can attack
                        case "attack":
                            Console.WriteLine("You attack the zombie!");
                            //player.Attack(10);
                            zombie.TakeDamage(player.attack);
                            // TODO adjust later
                            Console.WriteLine($"It took {player.attack * (1 - zombie.defense)} damage, and has {zombie.health} health points left.");
                            if (zombie.IsDefeated)
                            {
                                Console.WriteLine($"The zombie has been killed!\nYour attack strength has gone up by 5!\nThere are still {100 - g} zombies in the arena!");
                                player.attack += 5;
                                isBattleOver = true;
                            }
                            else
                            {
                                Console.WriteLine("The zombie attacks you back!");
                                //zombie.Attack(10);
                                player.TakeDamage(10);
                                Console.WriteLine($"You took {zombie.attack * (1 - player.defense)} damage, and have {player.health} health points left.");
                            }
                            break;

                        case "super attack":
                            //player.Attack(1000);
                            zombie.TakeDamage(1000);
                            Console.WriteLine("Holy cow! You dealt, like, so much damage just then!");
                            if (zombie.IsDefeated)
                            {
                                Console.WriteLine($"The zombie has been killed!\nThere are still {100 - g} zombies in the arena!");
                                isBattleOver = true;
                            }
                            break;

                        // if an unspecified command is entered
                        default:
                            Console.WriteLine("That isn't a known command. Try something else!");
                            break;
                    }

                    if (player.IsDefeated)
                    {
                        Console.WriteLine("You have been killed! Your game is over...");
                        Console.WriteLine($"Thank you for playing! \nYou killed {g} zombies before dying.\nPress ENTER twice to exit the game.");
                        Console.ReadKey();
                        return;
                    }

                }

                if (player.IsDefeated != true && isBattleOver != true)
                {
                    Console.WriteLine("Would you like to keep fighting? Type either continue or quit.");
                    string continuePlaying = Console.ReadLine();
                    if (continuePlaying == "quit")
                    {
                        isBattleOver = true;
                    }
                }
            }
        }
    }
}

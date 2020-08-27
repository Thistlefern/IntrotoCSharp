using System;

namespace ClassesHandbookExercise
{

    class Television
    {
        private int currentChannel;
        private int currentVolume;
        // increases the volume by one
        public void IncreaseVolume()
        {
            currentVolume++;
        }
        // decreases the volume by one
        public void DecreaseVolume()
        {
            currentVolume--;
        }
        // returns the current volume
        public int Volume()
        {
            return currentVolume;
        }
        // increases the channel num by one
        public void IncreaseChannel()
        {
            currentChannel++;
        }
        // decreases the channel num by one
        public void DecreaseChannel()
        {
            currentChannel--;
        }
        // returns the current channel
        public int Channel()
        {
            return currentChannel;
        }
    }

    // Manages a digital money store that can only be deposited.
    // The balance may not be withdrawn without retrieving the full value.
    class DigitalPiggyBank
    {
        // Maintains the current balance of the piggy bank.
        private float currentBalance = 100;
        // Add funds to the value of the current balance.

        public void Deposit(float net)
        {
            Console.WriteLine($"You are about to make a deposit. Your current balance is ${currentBalance}.");
            currentBalance += net;
            Console.WriteLine($"You just deposited ${net}. You balance is now ${currentBalance}.");
        }

        // Returns and clears the total current balance.
        public float Withdraw()
        {
            Console.WriteLine($"You are about to withdraw your entire balance of ${currentBalance}.");
            currentBalance = 0;
            Console.WriteLine($"Your balance is now ${currentBalance}.");
            return currentBalance;
        }
        // Returns the current balance of the function.
        public float Balance()
        {
            return currentBalance;
        }
        
    };
   
    class Program
    {
        static void Main(string[] args)
        {
            DigitalPiggyBank bank = new DigitalPiggyBank();
            bank.Deposit(50);
            bank.Withdraw();
        }
    }
}

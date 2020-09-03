using System;

namespace PropertiesExercise
{
    class Money
    {
        private double aud;

        public double AUD
        {
            get
            {
                return aud;
            }

            set
            {
                aud = value;
            }
        }

        public double USD
        {
            get
            {
                return aud * 0.8;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Money wallet = new Money();
            Console.WriteLine("How many Australian dollars do you have?");
            wallet.AUD = double.Parse(Console.ReadLine());
            Console.WriteLine($"You have {wallet.AUD} Australian dollars, which is equivalent to {wallet.USD} US dollars.");
        }
    }
}

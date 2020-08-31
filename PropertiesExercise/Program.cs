using System;

namespace PropertiesExercise
{
    class Money
    {
        public double aud;
        public double AUD
        {
            get => aud;
            set => aud=value;
        }
        public double usd;
        public double USD
        {
            get
            {
                return usd;
            }
            set
            {
               usd = aud * 0.8;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Money wallet = new Money();
            Console.WriteLine("How many Australian dollars do you have?");
            wallet.aud = double.Parse(Console.ReadLine());
            Console.WriteLine($"You have {wallet.aud} AUD, which is equal to {wallet.USD} USD.");
        }
    }
}

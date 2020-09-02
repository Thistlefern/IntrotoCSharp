using System;

namespace PropertiesExercise
{
    class Money
    {
        public double aud;
        public double usd;

        public double AUD
        {
            get
            {
                return aud;
            }
        }
        public double USD
        {
            get
            {
                return aud;
            }
            set
            {
                usd = value * 0.8;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Money wallet = new Money
            {
                aud = 10
            };

            Console.WriteLine($"AUD: {wallet.aud}");
            Console.WriteLine($"USD: {wallet.usd}");
            Console.WriteLine($"AUD: {wallet.AUD}");
            Console.WriteLine($"USD: {wallet.USD}");
        }
        
    }
}

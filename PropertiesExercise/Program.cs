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
                return usd;
            }
            set
            {
                value = aud * 0.8;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Money wallet = new Money();
            wallet.aud = 10;
            Console.WriteLine($"AUD: {wallet.aud}");
            Console.WriteLine($"USD: {wallet.usd}");
        }
    }
}

﻿using System;

namespace Functions
{
    class Program
    {
        static int numberOne = 10;
        static int numberTwo = 200;
        static void Start()
        {
            int biggestNumber = ReturnBiggestNumber(numberOne, numberTwo);
            Console.WriteLine("Of " + numberOne + " and " + numberTwo + " the biggest number is " + biggestNumber);
           
            Console.ReadKey();
        }
        static int ReturnBiggestNumber(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static void Main()
        {
            Start();
        }
    }
}


﻿using System;

namespace ex19_OneTwoALot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a number");

            string name = Console.ReadLine();
            int number = Int32.Parse(name);

            if (number <= 0)
            {
                Console.WriteLine("Not enough");
            }

            else if (number == 1)
            {
                Console.WriteLine("One");
            }

            else if (number == 2)
            {
                Console.WriteLine("Two");
            }

            else
            {
                Console.WriteLine("A lot");
            }

            Console.ReadLine();

            // Write a program that reads a number form the standard input,
            // If the number is zero or smaller it should print: Not enough
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A lot
        }
    }
}

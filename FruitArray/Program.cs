﻿using System;

namespace FruitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis puuvilja kasutaja sööb

            string[] fruit = new string[5] {"appel", "banana", "lemon", "orange", "grapes"};
            //Console.WriteLine(fruit[0]);
            //Console.WriteLine(fruit[1]);

            //Console.WriteLine("enter a number from 0 to 4:");
            Random rnd = new Random();

            int userNumber = rnd.Next(0, fruit.Length);

            Console.WriteLine($"Today you will have {fruit[userNumber]}.");






      }
    }
}

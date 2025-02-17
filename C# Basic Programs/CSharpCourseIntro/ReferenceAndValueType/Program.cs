﻿using System;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value TYPE
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);

            //Reference Type
            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" };
            string[] cities2 = new string[] { "Bolu", "Bursa", "Balıkesir" };
            cities2 = cities1;
            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]);

            Console.ReadLine();
        }
    }
}

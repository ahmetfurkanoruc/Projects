﻿using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2();

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(out number1, number2);

            Console.WriteLine(result2);
            Console.WriteLine(number1);
            //Console.WriteLine(Multiply(25, 4));
            //Console.WriteLine(Multiply(25, 4, 2));

            //Console.WriteLine(Add4(1, 2, 3, 4, 5));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added");
        }

        static int Add2(int number1 = 5 ,int number2 = 7)
        {
            return number1 + number2;
        }

        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        
        static int Multiply(int number1,int number2,int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(params int[] number)
        {
            return number.Sum();
        }
    }
}

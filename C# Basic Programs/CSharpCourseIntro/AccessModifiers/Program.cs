﻿using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Customer
    {
        int id;
    }

    class Student
    {
        public void Save()
        {
            Customer customer = new Customer();
        }
    }
}

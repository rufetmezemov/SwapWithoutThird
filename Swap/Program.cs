﻿using System;

namespace Change
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before a={a} b={b}");
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine($"After a={a} b={b}");
        }
    }
}

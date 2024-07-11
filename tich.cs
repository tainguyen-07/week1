﻿using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int result = Multiply(a, b);
        Console.WriteLine("Tích của " + a + " và " + b + " là: " + result);
    }

    static int Multiply(int x, int y)
    {
        return x * y;
    }
}
// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

public static void main(String[] args)
{
 

    isPrime(27);
}
public static boolean isPrime(int number)
{
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }

    return true;
}

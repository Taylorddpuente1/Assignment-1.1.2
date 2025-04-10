
using System;

class Program
{
    static void Main()
    {



        // ask user to input number

        Console.WriteLine("Enter the first number");

        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int num3 = num1 + num2;
        Console.WriteLine("The Result is :" + num3);

    }
}
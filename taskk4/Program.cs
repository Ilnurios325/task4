﻿Console.WriteLine("enter num1: ");
int num1 = 
Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter num2: ");
int num2 = 
Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter num3: ");
int num3 = 
Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
{
    Console.WriteLine("maximum number = "+max);
}    
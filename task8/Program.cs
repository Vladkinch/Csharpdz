﻿
// // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число > 1: ");
int a = Convert.ToInt32(Console.ReadLine());

int i = 2;

if (a > 1)
{
    while (i < a)
    {
        Console.Write(i + " ");
        i += 2;
    }
}
else{
    Console.WriteLine("Введенное число меньше или = 1");
}

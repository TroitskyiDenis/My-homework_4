﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int GetNumber(string msg)
{
    Console.Write(msg);
    int rez = Convert.ToInt32(Console.ReadLine());
    return rez;
}

Console.Clear();
Console.WriteLine("Введите число: ");
int rezult = 0;
int a = GetNumber(" ");
while (a > 0)
{
    rezult += a % 10;
    a = a / 10;
}
Console.WriteLine($"Сумма чисел: {rezult}");

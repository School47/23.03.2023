﻿// 1. Напишите программу на C#, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Введите первое число: ");
int a = Convert.ToInt32((Console.ReadLine()));
Console.Write("Введите второе число: ");
int b = Convert.ToInt32((Console.ReadLine()));
if (a == b * b)
{
    Console.WriteLine($"{a} является квадратом {b}. УРА!");
}
else
{
    Console.WriteLine($"{a} не является квадратом {b}. Обидно");
}
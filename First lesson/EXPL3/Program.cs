﻿//По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine() ?? "0");
if (a == b * b)
{
    Console.WriteLine($"Число A - {a} является квадратом числа B - {b}");
}
else
{
    Console.WriteLine($"Число A - {a} не является квадратом числа B - {b}");
}
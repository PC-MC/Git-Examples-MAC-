// Написать программу возведения числа А в целую стень B

int Degree(int a, int b)
{
    if (b < 1) return 1;
    return a * (Degree(a, b - 1));
}

Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine($"Возведение числа {numberA} в степень {numberB}: {Degree(numberA, numberB)}");
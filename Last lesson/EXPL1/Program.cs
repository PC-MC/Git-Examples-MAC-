// Показать натуральные числа от M до N, N и M заданы
Console.Write("Покажем натуральные числа от M до N");
Console.WriteLine();
Console.Write("Введите натуральное число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите натуральное число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");

if (m < n)
{
    while (m < n + 1)
    {
        Console.Write($"{m} ");
        m++;
    }
}
else if (m > n)
{
    while (m + 1 > n)
    {
        Console.Write($"{m} ");
        m--;
    }
}
else
{
    Console.WriteLine();
    Console.Write($"Вы ввели одинаковые числа, попробуйте еще.");
}

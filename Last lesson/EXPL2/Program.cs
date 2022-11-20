// Найти сумму элементов от M до N, N и M заданы

Console.Write("Посчитаем сумму элементов от M до N");
Console.WriteLine();
Console.Write("Введите натуральное число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите натуральное число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");

if (m < n)
{
    int sum = 0;
    while (m < n + 1)
    {
        Console.Write($"{m} ");
        sum = sum + m;
        m++;
    }
    Console.WriteLine();
   Console.Write($"Сумма чисел от M до N равна: {sum}");
}

else if (m > n)
{
    int sum = 0;
    while (m + 1 > n)
    {
        Console.Write($"{m} ");
        sum = sum + m;
        m--;
    }
    Console.WriteLine();
    Console.Write($"Сумма чисел от M до N равна: {sum}");
}
else
{
    
    Console.Write($"Вы ввели одинаковые числа.");
    Console.WriteLine();
    Console.WriteLine($"Сумма чисел от M до N равна {m+n}"??"0");
}

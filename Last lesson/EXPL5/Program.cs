// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

Console.Write("Введите число M: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int b = Convert.ToInt32(Console.ReadLine());

int Fibonacci(int n)
{
    if (n == 1) return a + b;
    if (n == 2) return (a + b) + b;

    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

Console.Write("Введите длинну последовательности: ");
int j = int.Parse(Console.ReadLine());
    for (int i = 1; i < j+1; i++)
    {
        Console.WriteLine($"f({i}) = {Fibonacci(i)}");
    }
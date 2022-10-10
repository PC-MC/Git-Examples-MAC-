//По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine() ?? "0");
if (a == b * b)
{
    Console.WriteLine($"Число A - {a} является квадратом числа B - {b}");
}
else if (b == a * a)
{
    Console.WriteLine($"Число B - {b} является квадратом числа A - {a}");
}
else
{
    Console.WriteLine($"Число A - {a} и число B - {b} не являются квадратами друг друга");
}
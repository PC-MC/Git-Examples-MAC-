// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

double ReadNumber(string message) // метод ввода числа
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
double b1 = ReadNumber("Введите точку b1 первой прямой:");
double k1 = ReadNumber("Введите точку k1 первой прямой:");
double b2 = ReadNumber("Введите точку b2 второй прямой:");
double k2 = ReadNumber("Введите точку k2 второй прямой:");

if (k1 == k2)
{
    Console.WriteLine("Прямые паралельны");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = ((k1 * b2) - (k2 * b1)) / (k1 - k2);
    Console.WriteLine($"({x}; {y})");
}

//Найти максимальное из трех чисел
Console.WriteLine("Введите 1е число");
int a = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите 2е число");
int b = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите 3е число");
int c = int.Parse(Console.ReadLine()??"0");
int max = Math.Max(a, b);
max = Math.Max(max, c);
Console.WriteLine($"Максимальное число из 3х равно: {max}");
Console.ReadLine();
// Найти кубы чисел от 1 до N
Console.WriteLine("Сейчас поищем кубы чисел от 1 - N");
Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine()??"0");
int index = 1;
while (index < n)
{
Console.WriteLine($"Число {index} его куб равен {index*index*index}");
index++;
}
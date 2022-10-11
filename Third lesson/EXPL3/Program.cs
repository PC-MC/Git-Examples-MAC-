// Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Сейчас найдем произведение чисел от 1 до N");
Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine()??"0");
int sum = 1;
int count = 1;
while (count < n+1) 
{
   sum = sum * count;
   count++;
}
 
Console.WriteLine($"Произведение чисел от 1 - N: {sum}");

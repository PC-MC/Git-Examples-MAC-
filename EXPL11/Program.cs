//Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine() ?? "0");
if (x<100)
{
  Console.WriteLine($" В числе {x} всего 2 цифры");  
}
while (x >= 1000)
{
    x = x / 10;
    Console.WriteLine($" Третья цифра числа равна {x % 10}");
}
// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти (1,2,3,4):");
int number = int.Parse(Console.ReadLine()??"0");
if (number == 1)
{
    Console.WriteLine("Диапозоны координат находятся в пределах (x > 0) / (y > 0)");
}
else if (number == 2)
{
    Console.WriteLine("Диапозоны координат находятся в пределах (x < 0) / (y > 0)");
}
else if (number == 3)
{
    Console.WriteLine("Диапозоны координат находятся в пределах (x < 0) / (y < 0)");
}
else if (number == 4)
{
    Console.WriteLine("Диапозоны координат находятся в пределах (x > 0) / (y < 0)");
}
else
{
    Console.WriteLine("Не верное значение четверти, попробуйте снова и выберете из (1,2,3,4)");
}
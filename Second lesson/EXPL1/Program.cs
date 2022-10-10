// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Write("Введите день недели:");
int n = int.Parse(Console.ReadLine() ?? "0");
if (n == 1)
{
    Console.WriteLine("Понедельник");
}
else if (n == 2)
{
    Console.WriteLine("Вторник");
}
else if (n == 3)
{
    Console.WriteLine("Среда");
}
else if (n == 4)
{
    Console.WriteLine("Четверг");
}
else if (n == 5)
{
    Console.WriteLine("Пятница");
}
else if (n == 6)
{
    Console.WriteLine("Суббота");
    Console.WriteLine("Выходной день");
}
else if (n == 7)
{
    Console.WriteLine("Воскресение");
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Ошибка, в неделе всего семь дней, а вы выбрали что-то другое!");
}

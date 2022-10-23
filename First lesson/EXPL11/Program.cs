//Найти третью цифру числа или сообщить, что её нет.

// Поиск 3ей цифры числа через деление
/*Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine() ?? "0");
if (x<100)
{
  Console.WriteLine($" В числе {x} всего 2 цифры");  
}
while (x >= 1000)
{
    x = x / 10; // Знак "/" - делит на 10 без остатка
}
    Console.WriteLine($" Третья цифра числа равна {x % 10}"); // Знак "%" показывает остаток от деления(Циффры после запятой)
*/


// Поиск 3ей цифры числа через индекс и строки
Console.WriteLine("Введите число");
string number = Console.ReadLine();
int count = 0;
while (count < number.Length)
{
    count++;
}
if (count <= 2)
{
    Console.WriteLine($"В числе: {number} меньше 3х цифр");
}
else if (count > 2)
{
    Console.WriteLine($"Третья цифра числа равна: {number[2]}");
}
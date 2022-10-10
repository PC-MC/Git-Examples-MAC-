//Выяснить, кратно ли число, если нет, вывести остаток.
Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine() ?? "0");
if (x % 2 == 0)
{
   Console.WriteLine("Число {0} - кратно 2.", x);
}
else
{
    Console.WriteLine("Число {0} - не кратно 2.", x);
}
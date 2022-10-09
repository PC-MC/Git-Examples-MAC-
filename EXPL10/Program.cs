//Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine() ?? "0");
if (x % 2 == 0)
{
   Console.WriteLine("{0} - кратно 2.", x);
}
else
{
    Console.WriteLine("{0} - не кратно 2.", x);
}
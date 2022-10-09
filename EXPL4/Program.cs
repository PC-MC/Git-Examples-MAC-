//Узнать является ли число четным
Console.Write("Введите целое число ");
int x = int.Parse(Console.ReadLine());
double x2 = x % 2;
if (x2==0)
{ 
Console.WriteLine("число четное");
}
else
{
Console.WriteLine("Число нечетное");
Console.ReadLine();
}
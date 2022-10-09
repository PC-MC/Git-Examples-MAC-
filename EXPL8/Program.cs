// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Random rnd = new Random();
int x = rnd.Next(10, 99);
Console.WriteLine("случайное от 10 до 99:");
Console.WriteLine(x);
int x1 = (x / 10);//первая цифра
int x2 = (x % 10);//вторая цифра
if (x1 > x2)
{
    Console.WriteLine("первая цифра больше второй");
    Console.WriteLine(x1);
}

else if (x1 == x2)
{
    Console.WriteLine("цифры равны");
    Console.WriteLine(x1); 
    Console.WriteLine(x2);   
}
else
{
    Console.WriteLine("вторая цифра больше первой");
    Console.WriteLine(x2);
}
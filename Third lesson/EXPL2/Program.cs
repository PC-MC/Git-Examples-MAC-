// Подсчитать сумму цифр в числе
Console.WriteLine("Давай посчитаем сумму цифр в числе");
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
int amount = 0;
while (number > 0)
{
 
amount = amount + number % 10;
number = number /10 ;

}
Console.WriteLine($"Сумма всех цифр числа равна: {amount}");
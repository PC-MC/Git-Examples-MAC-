// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Введите колличество чисел для ввода");
int n = int.Parse(Console.ReadLine()??"0");
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите {0}-й элемент", i + 1);
    a[i] = int.Parse(Console.ReadLine()??"0");
}
for (int i = 0; i < a.Length; i++)
{
     int number = a[i];
     int cube = (int)Math.Pow(number, 3);
     if (cube % 2 == 0)
          System.Console.WriteLine("Куб числа " + number + " равен " + cube + " и заканчивается на чётную цифру");
}
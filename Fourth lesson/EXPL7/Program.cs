// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.WriteLine("Введите количество элементов массива");
int size = int.Parse(Console.ReadLine() ?? "0");
double[] arrey = new double[size];

for (int index = 0; index < size; index++)
    arrey[index] = new Random().NextDouble() * 10;

Console.WriteLine("Ваш массив: ");
for (int index = 0; index < size; index++)
    Console.WriteLine($"{arrey[index]} ");

double min = arrey[0];
double max = arrey[0];
for (int index = 0; index < size; index++)
{
    if (min > arrey[index])
        min = arrey[index];
    else
    {
        if (max < arrey[index])
            max = arrey[index];
    }
}
Console.WriteLine();
Console.WriteLine($"Минимальное число массива равно: {min}");
Console.WriteLine($"Максимальное число массива равно {max}");
Console.WriteLine($"Разница между максимальным и минимальным элементами равна: {max - min}");
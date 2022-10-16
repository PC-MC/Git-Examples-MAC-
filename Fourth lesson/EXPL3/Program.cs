// Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел
Console.WriteLine("Введите количество элементов массива");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] arrey = new int[size];

for (int index = 0; index < size; index++)
    arrey[index] = new Random().Next(100, 1000);

Console.WriteLine("Ваш массив: ");

for (int index = 0; index < size; index++)
    Console.Write($"{arrey[index]} ");

int count1 = 0;
for (int index = 0; index < size; index++)
{
    if (arrey[index] % 2 == 0)
        count1++;
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве равно: {count1}");
Console.WriteLine($"Количество нечетных чисел в массиве равно: {size - count1}");

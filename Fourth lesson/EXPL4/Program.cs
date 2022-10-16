// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int size = 123;
int [] arrey = new int [size];

for (int index = 0; index < size; index++)
arrey [index] = new Random().Next(0,124);

Console.WriteLine("Ваш массив:");
for (int index = 0; index < size; index++)
Console.WriteLine( $"{arrey[index]}");

int count = 0;
for (int index = 0; index < size; index++)
{
    if(arrey[index] >= 10 && arrey[index] <= 99)
    count++;
}
Console.WriteLine();
Console.WriteLine($"Количество чисел из отрезка [10,99] в массиве равно: {count}");
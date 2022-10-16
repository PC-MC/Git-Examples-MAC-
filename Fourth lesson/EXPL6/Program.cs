// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.WriteLine("Введите размер массива:");
int size = int.Parse(Console.ReadLine());
int[] arrey = new int[size];

for (int index = 0; index < size; index++)
    arrey[index] = new Random().Next(0, 100);

Console.WriteLine("Ваш массив:");
for (int index = 0; index < size; index++)
    Console.WriteLine($"{arrey[index]}");

int first = 0;
int last = size - 1;
int composition = 0;
int count = 0;
while (first < last)
{
    composition = arrey[first] * arrey[last];
    first++;
    last--;
    count++;
    Console.WriteLine($"Произведение {count}ой пары чисел равно {composition}");
}

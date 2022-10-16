// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
Console.WriteLine("Задаем случайным образом 8 цифр в пределах 0 - 1");
int[] array = new int[8];
for (int index = 0; index < array.Length; index++)
{
    array[index] = new Random().Next(0, 2);
    Console.WriteLine($"Число {index + 1} = {array[index]}");
}
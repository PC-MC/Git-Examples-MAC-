// Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива

Console.WriteLine("Задаем случайным образом 12 цифр в пределах 0 - 9");
int[] array = new int[12];

for (int index = 0; index < array.Length; index++)
{
    array[index] = new Random().Next(0, 10);
    Console.WriteLine($"Число {index + 1} = {array[index]}");
}

int sum1 = 0;
int sum2 = 0;
for (int index = 0; index < array.Length; index++)
{
    if (array[index] >= 0)
        sum1 = sum1 + array[index];
    else
        sum2 = sum2 + array[index];

}
Console.WriteLine($"Сумма всех положительных чисел равна: {sum1}");
Console.WriteLine($"Сумма всех отрицательных чисел равна: {sum2}");
// Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива

Console.WriteLine("Задаем случайным образом 8 цифр в пределах 0 - 9");
int[] myArray = new int[12];
Random rand = new Random();

for (int x = 0; x < myArray.Length; x++)
{
    myArray[x] = rand.Next(0, 10);
    Console.WriteLine($"Число {x + 1} = {myArray[x]}");
}

int sum = 0;
for (int i = 0; i < myArray.Length; i++)
{
    sum = sum + myArray[i];
}
Console.WriteLine($"Сумма всех чисел равна: {sum}");
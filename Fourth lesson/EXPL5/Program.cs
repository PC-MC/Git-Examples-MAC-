// Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.WriteLine("Введите количество элементов массива");
int size = int.Parse(Console.ReadLine()??"0");
int [] arrey = new int [size];

for (int index = 0; index < size; index++)
    arrey[index] = new Random().Next(0,100);

Console.WriteLine("Ваш массив: ");
for (int index = 0; index < size; index++)
    Console.Write($"{arrey[index]} ");
int sum = 0;
for (int index = 0; index < size; index = index + 2) //Считаем элемент с индексом 0 стоит на нечетной позиции (для пользователя эта позиция равна 1)
    sum = sum + arrey[index];
Console.WriteLine();
Console.WriteLine($"Сумма чисел массива, стоящих на нечетной позиции равна: {sum}");
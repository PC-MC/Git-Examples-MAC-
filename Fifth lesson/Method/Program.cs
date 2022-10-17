// Поиск максимума
int Max(int[] arrey)
{
    int max = arrey[0];
    for (int index = 0; index < arrey.Length; index++)
        if (arrey[index] > max)
            max = arrey[index];
    Console.WriteLine($"Максимальное число в представленном массиве: {max}");
    return max;
}

// Поиск минимума
int Min(int[] arrey)
{
    int min = arrey[0];
    for (int index = 0; index < arrey.Length; index++)
        if (arrey[index] < min)
            min = arrey[index];
    Console.WriteLine($"Минимальное число в представленном массиве: {min}");
    return min;
}

// Поиск суммы элементов массива
int Sum(int[] arrey)
{
    int sum = 0;
    for (int index = 0; index < arrey.Length; index++)
        if (index < arrey.Length)
            sum = sum + arrey[index];
    Console.WriteLine($"Сумма элементов в представленном массиве: {sum}");
    return sum;
}

// Поиск произведения элементов массива
int Mul(int[] arrey)
{
    int mul = 1;
    for (int index = 0; index < arrey.Length; index++)
        if (index < arrey.Length)
            mul = mul * arrey[index];
    Console.WriteLine($"Произведение элементов в представленном массиве: {mul}");
    return mul;
}

// Поиск индекса заданного элемента в массиве.
// Если такого элемента в массиве нет то возвращать -1
int Serch(int[] arrey)
{
    Console.WriteLine("Введите число чей индекс требуется найти");
    int find = int.Parse(Console.ReadLine());
    int n = arrey.Length;
    int index = 0;
    
    while (index < n)
    {

        if (arrey[index] == find)
        {

            Console.WriteLine($"Число найдено, его индекс:{index}");
            break;
        }
        index++;
    }

    if (index == n)
    {
        Console.WriteLine("Такого числа нет в массиве(-1)");
    }

    return index;
}




Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] arrey = new int[size];

for (int index = 0; index < arrey.Length; index++)

    arrey[index] = new Random().Next(1, 10);
Console.WriteLine("Ваш массив:  ");
for (int index = 0; index < arrey.Length; index++)
    Console.Write($"{arrey[index]} ");
Console.WriteLine();


int x = Serch(arrey);


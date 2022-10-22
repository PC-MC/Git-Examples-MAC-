// Заполнение массива
void FillArrey(int[] arrey, int min, int max)
{
    for(int index = 0; index < arrey.Length; index++)
    {
        arrey[index] = new Random().Next(min,max);
    }
}

// Печать массива
void PrintArrey(int[] arrey)
{
    for(int index = 0; index < arrey.Length; index++)
    {
        Console.Write($"{arrey[index]}");
    }
}

// Поиск максимума
int Max(int[] arrey)
{
    int max = arrey[0];
    for (int index = 0; index < arrey.Length; index++)
        if (arrey[index] > max)
            max = arrey[index];
    Console.Write($"Максимальное число в представленном массиве: {max}");
    return max;
}

// Поиск минимума
int Min(int[] arrey)
{
    int min = arrey[0];
    for (int index = 0; index < arrey.Length; index++)
        if (arrey[index] < min)
            min = arrey[index];
    Console.Write($"Минимальное число в представленном массиве: {min}");
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
int SerchIndex(int[] arrey)
{
    Console.Write("Введите число чей индекс требуется найти: ");
    int find = int.Parse(Console.ReadLine());
    int n = arrey.Length;
    int index = 0;

    while (index < n)
    {

        if (arrey[index] == find)
        {

            Console.WriteLine($"Число найдено, его индекс: {index}");
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

// Проверка наличия элемента в массиве. 
// Возвращает true, если элемент в массиве есть, false – нет.
int SerchNumber(int[] arrey)
{
    Console.Write("Введите число которое требуется найти: ");
    int find = int.Parse(Console.ReadLine()??"0");
    int n = arrey.Length;
    int index = 0;

    while (index < n)
    {

        if (arrey[index] == find)
        {

            Console.WriteLine($"Число найдено:{arrey[index]}");
            break;
        }
        index++;
    }

    if (index == n)
    {
        Console.WriteLine("Такого числа нет в массиве");
    }

    return arrey[index];
}

// Проверка наличия элемента в массиве. 
// Возвращает true, если элемент в массиве есть, false – нет.
bool FindNum(int []arrey)
{
    Console.Write("Введите число которое требуется найти: ");
    int num = int.Parse(Console.ReadLine()??"0");
for(int index = 0; index < arrey.Length; index++)
{
    if(arrey[index]==num)
    {
        return true;
    }
}
return false;
}

// Поиск среднего арифметического
double Average(int[]arrey)
{
    int sum = 0;
    for(int index = 0; index < arrey.Length; index++)
    {
        sum = sum + arrey[index];
    }
    Console.WriteLine($"Среднее арифметическое равно: {sum/2}");
    return sum/2;
}

Console.WriteLine("Начало работы с числами");
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()??"0");
int[] arrey = new int[size];

FillArrey(arrey,1,10);
// Вывод массива
Console.Write("Ваш массив: ");
PrintArrey(arrey);
Console.WriteLine("");
// Поиск максимальногочисла
int max = Max(arrey);
Console.WriteLine("");
// Поиск минимального числа
int min = Min(arrey);
Console.WriteLine("");
// Нахождение суммы чисел
int sum = Sum(arrey);
// Нахождение среднего арифметического
Console.Write($"Среднее арифметическое равно {sum/2}");

//Console.WriteLine("");
//double average = Average(arrey);

// Нахождение произведения чисел
int multi = Mul(arrey);
// Проверка на наличие числа в массиве
bool serch = FindNum(arrey);
Console.WriteLine($"Наличие числа в массиве: {serch}");
// Поиск индекса числа
int index = SerchIndex(arrey);
Console.WriteLine("Программа завершила работу.");


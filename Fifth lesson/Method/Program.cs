// Заполнение массива
void FillArrey(int[] arrey, int min, int max)
{
    for (int index = 0; index < arrey.Length; index++)
    {
        arrey[index] = new Random().Next(min, max);
    }
}

// Печать массива
void PrintArrey(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"{array[index]} ");
    }
}

// Поиск максимума
int Max(int[] array)
{
    int max = array[0];
    for (int index = 0; index < array.Length; index++)
        if (array[index] > max)
            max = array[index];
    Console.Write($"Максимальное число в представленном массиве: {max}");
    return max;
}

// Поиск минимума
int Min(int[] array)
{
    int min = array[0];
    for (int index = 0; index < array.Length; index++)
        if (array[index] < min)
            min = array[index];
    Console.Write($"Минимальное число в представленном массиве: {min}");
    return min;
}

// Поиск суммы элементов массива
int Sum(int[] array)
{
    int sum = 0;
    for (int index = 0; index < array.Length; index++)
        if (index < array.Length)
            sum = sum + array[index];
    Console.WriteLine($"Сумма элементов в представленном массиве: {sum}");
    return sum;
}

// Поиск произведения элементов массива
int Mul(int[] array)
{
    int mul = 1;
    for (int index = 0; index < array.Length; index++)
        if (index < array.Length)
            mul = mul * array[index];
    Console.WriteLine($"Произведение элементов в представленном массиве: {mul}");
    return mul;
}

// Поиск индекса заданного элемента в массиве.
// Если такого элемента в массиве нет то возвращать -1
int SerchIndex(int[] array)
{
    Console.Write("Введите число чей индекс требуется найти: ");
    int find = int.Parse(Console.ReadLine());
    int n = array.Length;
    int index = 0;

    while (index < n)
    {

        if (array[index] == find)
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
int SerchNumber(int[] array)
{
    Console.Write("Введите число которое требуется найти: ");
    int find = int.Parse(Console.ReadLine() ?? "0");
    int n = array.Length;
    int index = 0;

    while (index < n)
    {

        if (array[index] == find)
        {

            Console.WriteLine($"Число найдено:{array[index]}");
            break;
        }
        index++;
    }

    if (index == n)
    {
        Console.WriteLine("Такого числа нет в массиве");
    }

    return array[index];
}

// Проверка наличия элемента в массиве. 
// Возвращает true, если элемент в массиве есть, false – нет.
bool FindNum(int[] array)
{
    Console.Write("Введите число которое требуется найти: ");
    int num = int.Parse(Console.ReadLine() ?? "0");
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] == num)
        {
            return true;
        }
    }
    return false;
}

// Поиск среднего арифметического
double Average(int[] array)
{
    int sum = 0;
    for (int index = 0; index < array.Length; index++)
    {
        sum = sum + array[index];
    }
    Console.WriteLine($"Среднее арифметическое равно: {sum / 2}");
    return sum / 2;
}

// Подсчёт количества отрицательных элементов массива
int Count(int[] array)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)

        if (array[index] < 0)
        {
            count++;
        }
    return count;
}

// Подсчёт количества вхождений элемента в массив
int CountIdentNumbers(int[] array)
{
    Console.Write("Ведите число которое будем считать: ");
    int findnumber = int.Parse(Console.ReadLine() ?? "0");
    int count = 0;
    for (int index = 0; index < array.Length; index++)

        if (array[index] == findnumber)
        {
            count++;
        }
    return count;
}

// Подсчёт количества чётных элементов в массив
int CountEvenNum(int[] array)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

// Подсчёт количества положительных элементов в массиве
int CountPositNum(int[] array)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] > 0)
        {
            count++;
        }
    }
    return count;
}

// Подсчёт количества нечётных элементов в массиве
int CountOddNum(int[] array)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] % 2 != 0) // != знак неравенства
        {
            count++;
        }
    }
    return count;
}

// Проверка является ли массив отсортированным по возрастанию. 
// Если массив отсортирован, то возвращать true, иначе - false.
bool SortingCheck(int[] array)
{
    int index = 0;
    while (index < array.Length)
        {
        if (array[index] <= array[index + 1])
        return true;
        index++;
        }
    return false;
}

Console.WriteLine("Начало работы с числами");
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[size];

Console.Write("Введите минимальное число массива: ");
int minAR = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите максимальное число массива: ");
int maxAR = int.Parse(Console.ReadLine() ?? "0");

// Заполнение массива
FillArrey(array, minAR, maxAR);

// Вывод массива
Console.Write("Ваш массив: ");
PrintArrey(array);
Console.WriteLine("");

// Проверка сортировки
bool check = SortingCheck(array);
Console.WriteLine($"Массив отсортирован по возрастанию: {check}");

// Поиск максимальногочисла
int max = Max(array);
Console.WriteLine("");

// Поиск минимального числа
int min = Min(array);
Console.WriteLine("");

// Подсчёт количества чётных элементов в массив
int count3 = CountEvenNum(array);
Console.WriteLine($"Четных чисел в массиве: {count3}");

// Подсчёт количества нечётных элементов в массиве
int count5 = CountOddNum(array);
Console.WriteLine($"Нечетных чисел в массиве: {count5}");

// Подчсет отрицательных чисел в массиве
int count = Count(array);
Console.WriteLine($"Отрицательных числе в массиве: {count}");

// Подсчёт количества положительных элементов в массиве
int count4 = CountPositNum(array);
Console.WriteLine($"Положительных чисел в массиве: {count4}");

// Нахождение суммы чисел
int sum = Sum(array);

// Нахождение среднего арифметического
Console.WriteLine($"Среднее арифметическое равно: {sum / 2}");
//Console.WriteLine("");
//double average = Average(array);

// Нахождение произведения чисел
int multi = Mul(array);
if (multi == 0)
{
    Console.WriteLine("В массиве есть: 0, умножение на него дает результат: 0");
}

// Проверка на наличие числа в массиве
bool serch = FindNum(array);
Console.WriteLine($"Наличие числа в массиве: {serch}");

// Поиск индекса числа
int index = SerchIndex(array);

// Подсчет вхождения числа в массив
int count2 = CountIdentNumbers(array);
Console.WriteLine($"Искомых чисел в массиве: {count2}");


Console.WriteLine("Программа завершила работу.");

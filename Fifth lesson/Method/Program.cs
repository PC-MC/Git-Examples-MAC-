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
    return max;
}

// Поиск минимума
int Min(int[] array)
{
    int min = array[0];
    for (int index = 0; index < array.Length; index++)
        if (array[index] < min)
            min = array[index];
    return min;
}

// Поиск суммы элементов массива
int Sum(int[] array)
{
    int sum = 0;
    for (int index = 0; index < array.Length; index++)
        if (index < array.Length)
            sum = sum + array[index];
    return sum;
}

// Поиск среднего арифметического
int Average(int[] array)
{
    return Sum(array)/array.Length;
}

// Поиск произведения элементов массива
int Mul(int[] array)
{
    int mul = 1;
    for (int index = 0; index < array.Length; index++)
        if (index < array.Length)
            mul = mul * array[index];
    return mul;
}

// Поиск индекса заданного элемента в массиве.
// Если такого элемента в массиве нет то возвращать -1
int SerchIndex(int[] array, int find)
{
    int n = array.Length;
    int index = 0;
    int fal = -1;

    while (index < n)
    {

        if (array[index] == find)
        {
            return index;
        }
        index++;
    }

    if (index == n) return fal;
    return fal;
}

// Проверка наличия элемента в массиве. 
// Возвращает true, если элемент в массиве есть, false – нет.
bool FindNum(int[] array, int num)
{

    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] == num)
        {
            return true;
        }
    }
    return false;
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
int CountIdentNumbers(int[] array, int findnumber)
{
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
    for (int i = 0; i < array.Length - 1; i++)
        if (array[i] > array[i + 1])
            return false;
    return true;

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

// Поиск максимального числа
int max = Max(array);
Console.Write($"Максимальное число в представленном массиве: {max}");
Console.WriteLine("");

// Поиск минимального числа
int min = Min(array);
Console.Write($"Минимальное число в представленном массиве: {min}");
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
Console.WriteLine($"Сумма элементов в представленном массиве: {sum}");

// Нахождение среднего арифметического
int x = Average(array);
Console.WriteLine($"Среднее арифметическое равно: {x}");
//Console.WriteLine("");
//double average = Average(array);

// Нахождение произведения чисел
int multi = Mul(array);
Console.WriteLine($"Произведение элементов в представленном массиве: {multi}");
if (multi == 0)
{
    Console.WriteLine("В массиве есть: 0, умножение на него дает результат: 0");
}

// Проверка на наличие числа в массиве
Console.Write("Введите число которое требуется найти: ");
int num = int.Parse(Console.ReadLine() ?? "0");
bool serch = FindNum(array, num);
Console.WriteLine($"Наличие числа в массиве: {serch}");

// Поиск индекса числа
Console.Write("Введите число чей индекс требуется найти: ");
int find = int.Parse(Console.ReadLine() ?? "0");
int index = SerchIndex(array, find);
Console.WriteLine($"Число найдено, его индекс: {index}");


// Подсчет вхождения числа в массив
Console.Write("Ведите число которое будем считать: ");
int findnumber = int.Parse(Console.ReadLine() ?? "0");
int count2 = CountIdentNumbers(array, findnumber);
Console.WriteLine($"Искомых чисел в массиве: {count2}");


Console.WriteLine("Программа завершила работу.");

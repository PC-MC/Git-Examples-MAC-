// Функция, которая вычисляет число a в степени n
int NumXTimes(int a, int n)
{
    int index = 0;
    int mult = 1;
    while (index < n)
    {
        mult = mult * a;
        index++;
    }
    return mult;
}

// Функция, которая вычисляет факториал числа n
int Factorial(int n)
{
    if (n == 1) return 1;

    return n * Factorial(n - 1);
}

// Функция, которая вычисляет сумму цифр произвольного целого числа n
int Summary(int numbers)
{
    int summary = 0;
    while (numbers > 0)
    {
        summary = summary + numbers % 10; // прибавляем последнюю цифру - остаток от деления на 10
        numbers = numbers / 10; // делим число на 10 без остатка, чтобы убрать последнюю цифру
    }
    return summary;
}

// Функция, которая проверяет является ли заданное число n полиндромом
bool IsPalindrome(string number)
{
    for (int i = 0; i < number.Length / 2; ++i)
        if (number[i] != number[number.Length - 1 - i]) return false;
    return true;
}

// Функция, складывающую два целых числа
int Summary2Num(int a, int b)
{
    int sum = a + b;
    return sum;
}

// Функция, определяющую является ли число простым, то есть возвращающую true, если число простое, иначе - false
bool SimpleNumCheck(int a)
{
    if (a > 1)
    {
        for (int i = 2; i < a; i++)
            if (a % i == 0) return false;
        return true;
    }
    else return false;
}
// Функция, определяющую является ли число чётным, то есть возвращающую true, если число чётное, иначе - false
bool Parity(double a)
{
    if (a % 2 == 0) return true;

    return false;
}

Console.WriteLine("Начало работы");

Console.WriteLine("Введите число, которое будем возводить в степень: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int degree = int.Parse(Console.ReadLine());
int unknown = NumXTimes(number, degree);
Console.WriteLine($"Число: {number} в степени: {degree} равно: {unknown}");

Console.WriteLine("Введите число, факториал которого будем искать: ");
int numberFact = int.Parse(Console.ReadLine());
int b = Factorial(numberFact);
Console.WriteLine($"Факториал числа: {numberFact} равен: {b}");

Console.WriteLine("Введите число, сумму цифр которого мы посчитаем: ");
int numbersum = int.Parse(Console.ReadLine() ?? "0");
int findsum = Summary(numbersum);
Console.WriteLine($"Сумма цифр числа: {numbersum} равна: {findsum}");

Console.WriteLine("Введите число которое будем проверять на полиндромность:");
string polynum = (Console.ReadLine() ?? "0");
bool unsver = IsPalindrome(polynum);
Console.WriteLine($"Поиндромность числа {polynum}: {unsver}");

Console.WriteLine("Введите первое число, которое будем складывать: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число, которое будем складывать: ");
int numberB = int.Parse(Console.ReadLine());
int sumAB = Summary2Num(numberA, numberB);
Console.WriteLine($"Число: {numberA} + число: {numberB} равно: {sumAB}");

Console.WriteLine("Введите число, чтобы проверить простое ли оно: ");
int numbersimple = int.Parse(Console.ReadLine());
bool numsimcheck = SimpleNumCheck(numbersimple);
Console.WriteLine($"Проверка числа: {numbersimple} показала: {numsimcheck}");

Console.WriteLine("Введите число, чтобы узнать четное ли оно: ");
double numberpar = double.Parse(Console.ReadLine());
bool numsimpar = Parity(numberpar);
Console.WriteLine($"Проверка числа: {numberpar} показала: {numsimpar}");

Console.WriteLine("Завершение работы");
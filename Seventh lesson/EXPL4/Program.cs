// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
void FillArray(int [,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray(int [,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i,j]} ");
        }

        Console.WriteLine();
    }
}

/*
bool Findnumb (int [,] mat, int find)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            if (mat[i, j] == find)
            {
                return true;
            }
        }
    }
return false;
}
*/

string Position(int[,] array, int num)
{
    string result = string.Empty;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            if (num == array[m, n]) result += $"({m}, {n})";
        }
    }
    if (result == string.Empty) result = "Такого элемента нет";
    return result;
}

Console.WriteLine("Введите количество строк:" );
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:" );
int k = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [n,k];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("Введите число которое нужно найти:" );
int x = Convert.ToInt32(Console.ReadLine());
/*
bool find = Findnumb(matrix, x);
Console.WriteLine($"Наличие числа в массиве: {find}" );
*/

Console.WriteLine($"Число находится на позиции: {Position(matrix,x)}");





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

Console.WriteLine("Введите количество строк:" );
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:" );
int k = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [n,k];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("Введите число которое нужно найти:" );
int x = Convert.ToInt32(Console.ReadLine());
bool find = Findnumb(matrix, x);
Console.WriteLine($"Наличие числа в массиве: {find}" );





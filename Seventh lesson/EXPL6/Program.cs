// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

void Printmatr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        
      Console.Write($"{array[i]} ");
    }
     Console.WriteLine();

}

void FillArray(int[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i,j] = new Random().Next(1,10);
            }
    }
}

void AverageSum(int[,] matr, double []array)
{
    int index = 0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        
        int sum = 0;
        for (int j = 0; j < matr.GetLength(0);j++)
        {
            sum= sum + matr[j, i];
           
        }
     array[index] = sum/matr.GetLength(1);
     index++;
    }
}

Console.WriteLine("Введите размерность массива");
Console.Write("Введите количестиво строк: ");
int m  = int.Parse(Console.ReadLine());;
Console.Write("Введите количество столбцов: ");
int n  = int.Parse(Console.ReadLine());;
int[,] matrix = new int[m, n];
double [] array = new double [m];
FillArray(matrix);
Console.WriteLine();
Console.WriteLine("Матрица: ");
Printmatr(matrix);
AverageSum(matrix,array);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое столбцов: ");
PrintArray(array);
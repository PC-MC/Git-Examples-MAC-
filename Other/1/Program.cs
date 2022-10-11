int[] array = { 1, 2, 3, 4, 5, 6 };
int n = array.Lenght;
int find = int.Parse(Console.ReadLine()??"0");
int index = 0;

if (index < n)
{
     if (array[index] == find)
     {
        Console.WriteLine($"Число {find} имеет индекс:{index}");
     }
     index++;
}

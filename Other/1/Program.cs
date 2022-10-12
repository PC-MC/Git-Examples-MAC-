Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите {0}-й элемент", i + 1);
    a[i] = int.Parse(Console.ReadLine());
}
int k = 0;
for (int i = 0; i < a.Length; i++)
    if (a[i] % 2 == 0)
        k++;
Console.WriteLine(k);
Console.ReadKey();
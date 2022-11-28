// Написать программу которая из массива строк создает другой массив строк
// длинна которых не привышает 3х символов.

Console.WriteLine("Введите слова и смволы через пробел:");
string [] Array = Console.ReadLine().Split(' ');
Console.WriteLine();

void Print_Arr (string [] My)              
{                                           
 for (int i = 0; i < My.Length; i++)
    {
        Console.Write(My[i] + " ");         
    }                                       
}                                             
                                               
Print_Arr(Array);

string [] Final (string [] MyArray)
{
    string [] Itog = new string [MyArray.Length];
    for (int i = 0; i < MyArray.Length; i++)
    {
        if (MyArray[i].Length <= 3)
        {
            Itog[i] = MyArray[i];
           
        }
    }
    return Itog;
}
Console.Write("=> ");
Print_Arr(Final(Array));

Console.WriteLine();
Console.WriteLine("Завершение работы");
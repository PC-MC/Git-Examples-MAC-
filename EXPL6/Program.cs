//Показать последнюю цифру трёхзначного числа
Console.Write("Введите трехзначное целое целое число ");
int n = int.Parse(Console.ReadLine());
if(n > 99)
{
    //если ввести Console.WriteLine((n / 100) % 10); 
    //то будет показываться первая цифра
    Console.WriteLine("третья цифра числа");
    Console.WriteLine(n % 10);
}
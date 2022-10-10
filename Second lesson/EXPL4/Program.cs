// Найти расстояние между точками в пространстве 2D/3D
Double x1 = 0;
Double x2 = 0;
Double y1 = 0;
Double y2 = 0;
Double distance;

Console.WriteLine("Введите координаты:");

Console.Write("x1=");
x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1=");
y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("x2=");
x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2=");
y2 = Convert.ToDouble(Console.ReadLine());


distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine("Расстояние между точками равно:" + distance);
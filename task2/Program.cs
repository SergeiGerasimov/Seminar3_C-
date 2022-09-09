// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве
// А (3,6); В (2,1) - 5,09
// А (7,-5); В (1, -1) - 7,21

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X - ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y - ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X - ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y - ");
int y2 = Convert.ToInt32(Console.ReadLine());


double cord = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));

Console.WriteLine(Math.Round(cord,2, MidpointRounding.ToZero));//round - округление
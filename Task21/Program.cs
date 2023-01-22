Console.Clear();

/* Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Write("Введите координаты первой точки: x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты первой точки: y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты первой точки: yz: ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты второй точки: x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты второй точки: y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты второй точки: z2: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1),2));
result = Math.Round(result, 2);
Console.WriteLine($"Расстояние между точками в 3D пространстве = {result}");

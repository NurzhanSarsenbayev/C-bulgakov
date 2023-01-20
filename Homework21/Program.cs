// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


double Distance(int point1,int point2,int point3, int point4, int point5, int point6)
{
 return Math.Sqrt(Math.Pow((point3 - point1), 2) + Math.Pow((point4 - point2), 2) + Math.Pow((point6 - point5), 2));
}


Console.WriteLine("Type in your coordinates for point A (x)");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type in your coordinates for point A (y)");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type in your coordinates for point A (z) ");
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type in your coordinates for point B (x) ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type in your coordinates for point B (y) ");
int by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type in your coordinates for point B (z) ");
int bz = Convert.ToInt32(Console.ReadLine());


double endResult = Distance(ax,ay,bx,by,az,bz);
double resultRound = Math.Round(endResult,2,MidpointRounding.ToZero);
Console.WriteLine($"Distance between ({ax},{ay},{az}) and ({bx},{by},{bz}) is {resultRound}");




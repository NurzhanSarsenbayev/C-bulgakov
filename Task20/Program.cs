// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


// Math.Pow(2, 10);
// Math.Sqrt(5);

// double d = 5.099976355;
// double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
// Console.WriteLine($"{dRound}");

double Distance(int point1,int point2,int point3, int point4)
{
 return Math.Sqrt(Math.Pow((point3 - point1), 2) + Math.Pow((point4 - point2), 2));
}


Console.WriteLine("Type in your coordinates for point A (x)");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type in your coordinates for point A (y)");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type in your coordinates for point B (x) ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type in your coordinates for point B (y) ");
int by = Convert.ToInt32(Console.ReadLine());

double endResult = Distance(ax,ay,bx,by);
double resultRound = Math.Round(endResult,2,MidpointRounding.ToZero);
Console.WriteLine($"Distance between ({ax},{ay}) and ({bx},{by}) is {resultRound}");




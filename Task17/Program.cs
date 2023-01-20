// Проверка нав результат(?)

// striing str = "1234";
// int result;
// bool res = int.TryParse(str, out result);

// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

int Coordinates(int point1,int point2)
{
if (point1>0 && point2>0) return 1;
if (point1<0 && point2>0) return 2;
if (point1<0 && point2<0) return 3;
if (point1>0 && point2<0) return 4;
return 0;
}


Console.WriteLine("Type in you coordinates for X and Y");
Console.WriteLine("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

// int coord = Coordinates(x, y);
// Console.WriteLine($"Coordinates are in {coord} region");

int coord = Coordinates(x,y);
string result = coord > 0
? $"Coordinates are in the region {coord}"
: "Invalid Coordinates";
Console.WriteLine(result);


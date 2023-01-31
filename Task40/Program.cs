// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool TriangleTrue(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b) return true;
    else return false;
}

Console.WriteLine("Type your 3 numbers for sides of triangle");
int side1 = Convert.ToInt32(Console.ReadLine());
int side2 = Convert.ToInt32(Console.ReadLine());
int side3 = Convert.ToInt32(Console.ReadLine());
bool triangleTrue = TriangleTrue(side1 , side2, side3);
string result = triangleTrue ? "This triangle is possible" : "This triangle is impossible";
Console.WriteLine(result);

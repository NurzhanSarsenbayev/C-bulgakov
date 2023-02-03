// Напишите программу, которая найдёт точку пересечения двух прямых,

// заданных уравнениями

//  y = k1 * x + b1, 

//  y = k2 * x + b2;

// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

double[] PointsOfIntersection(double val1,double val2,double val3,double val4)
{
    double[] arr= new double[2];

    arr[0] = Math.Round((val3 - val1)/(val2-val4),2);
    arr[1] = Math.Round(val2*arr[0]+val1,2);
    return arr;
}

void PrintArray(double[] arr)
{
   Console.Write("(");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(")");
}

Console.WriteLine("Type in your values for b1, k1, b2, k2");
double b1 = Convert.ToDouble(Console.ReadLine());
double k1 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());
double[] pointOfIntersection = PointsOfIntersection(b1,k1,b2,k2);
Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ");
PrintArray(pointOfIntersection);

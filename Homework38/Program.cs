// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] GenerateDoubleArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return array;
}
void PrintDoubleArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
double DiffMinMax(double[] array)
{
    double diff = default;
    double minNum = array[0];
    double maxNum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<minNum) minNum = array[i];
        if (array[i]>maxNum) maxNum = array[i];
    }
    diff = maxNum-minNum;
    return diff;
}
double[] arr = GenerateDoubleArray(5,0, 10);
PrintDoubleArray(arr);
double diffMinMax= Math.Round(DiffMinMax(arr),2);
Console.Write($" -> {diffMinMax}");
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GenerateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max - 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} |");
        }

        Console.WriteLine();
    }
}
// void MeanRow(int[,] matrix)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         double mean = default;
//         double count = default;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             mean += matrix[i, j];
//             count++;
//         }
//         mean = Math.Round(mean / count, 1);
//         Console.Write($"{mean,7}");
//     }
// }
double[] MeanRow(int[,] matrix)
{
    double[] meanRow = new double[matrix.GetLength(1)];
    int k = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double mean = default;
        double count = default;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            mean += matrix[i, j];
            count++;
        }
        meanRow[k] = Math.Round(mean / count, 1);
        k++;
    }
    return meanRow;
}
void PrintDoubleArray(double[] array)
{
    Console.Write("|");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i],5} |");
        else Console.Write($"{array[i],5}");
    }
    Console.WriteLine(" |");
}
int[,] matr = GenerateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(matr);
Console.WriteLine("");
// MeanRow(matr);
double[] mean = MeanRow(matr);
Console.WriteLine("v Means of values in columns v");
Console.WriteLine("");
PrintDoubleArray(mean);
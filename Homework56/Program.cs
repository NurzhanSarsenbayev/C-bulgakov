// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// bool IsRectangular(int rows, int columns)   //Проверка на прямоугольность, хотя в задаче написано что мы сами задаем массив.
// {
//     return rows != columns;
// }
int[,] GenerateRectangularMatrixRndInt(int rows, int columns, int min, int max)
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
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");

}
int[] SmallestRowSumArray(int[,] matrix)
{
    int sum = default;
    int j = 0; int i = 0;
    int[] array = new int[matrix.GetLength(0)];
    while (i < array.Length)
    {
        while (j < matrix.GetLength(0))
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                sum += matrix[j, k];
            }
            array[i] = sum;
            sum = 0;
            j++;
            i++;
        }
    }
    return array;
}
int SmallestRowCompare(int[] array)
{
    int minValue = array[0];
    int minIndex = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<minValue) 
        {
            minValue = array[i];
            minIndex=i;
        }
    }
    return minIndex;
}
int[,] matr = GenerateRectangularMatrixRndInt(4, 3, 0, 10);
PrintMatrix(matr);
int[] arr = SmallestRowSumArray(matr);
Console.WriteLine();
Console.WriteLine("List of row sums : ");
PrintArray(arr);
int result = SmallestRowCompare(arr);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Row {result} has smallest sum");
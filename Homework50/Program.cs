// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,

// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

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
void FindMatrixValue(int[,] matrix, int row, int column)
{
    if ((row <= matrix.GetLength(0)-1 && row >= 0) && (column <= matrix.GetLength(1)-1 && column >= 0))
    {
        int targetValue = default;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == row && j == column)
                {
                    targetValue = matrix[i, j];
                }
            }
        }
                    Console.WriteLine($"Value of in row {row} - column {column} is {targetValue}");
    }
    else Console.WriteLine("Invalid index");
}
int[,] matr = GenerateMatrixRndInt(4, 4, 0, 4);
PrintMatrix(matr);
Console.WriteLine();
Console.WriteLine("Type in your row");
int rowFind = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type in your column");
int columnFind = Convert.ToInt32(Console.ReadLine());
FindMatrixValue(matr, rowFind, columnFind);

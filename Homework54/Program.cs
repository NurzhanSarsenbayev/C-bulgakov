﻿// Задача 54: Задайте двумерный массив.
//  Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2
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
int[,] SortMatrixValueDown(int[,] matrix)
{
    int temp;
    int i = 0;
    int size = matrix.GetLength(1);
    while (i <= matrix.GetLength(0) - 1)
    {
        for (int j = 0; j < size; j++)
        {
            for (int k = j + 1; k < size; k++)
            {
                if (matrix[i, j] <= matrix[i, k])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
        i++;
    }
    return matrix;
}
int[,] matrixHomework = GenerateMatrixRndInt(5, 5, 1, 10);
PrintMatrix(matrixHomework);
Console.WriteLine();
int[,] matrixHomework2 = SortMatrixValueDown(matrixHomework);
PrintMatrix(matrixHomework2);

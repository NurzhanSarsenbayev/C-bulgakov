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
 //Сделал метод с расчетом на то, что бы визуально было понятней на примере.
// Отсчет начиная не с 0 индекса а с *первой* строки/колонны 

                          
{
    int targetValue = default;
    if ((row >= matrix.GetLength(0) || row > 0) && (column >= matrix.GetLength(1) || column > 0)) // тут вместо > 0, можно >-1
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == row - 1 && j == column - 1)  
                // if (i == row && j == column) Этот вариант более технически верный
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

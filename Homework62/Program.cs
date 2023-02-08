// *Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Универсальный метод, когда понял как работает решил что было бы интересно сделать

int[,] GenerateSpiralMatrixInt(int rows, int columns, int value)
{
    int[,] matrix = new int[rows, columns];
    int row = matrix.GetLength(0);
    int column = matrix.GetLength(1);
    for (int j = 0; j < column; j++)
    {
        matrix[0, j] = value;
        value++;
    }
    for (int i = 1; i < row; i++)
    {
        matrix[i, column - 1] = value;
        value++;
    }
    for (int j = column - 2; j >= 0; j--)
    {
        matrix[row - 1, j] = value;
        value++;
    }
    for (int i = row - 2; i > 0; i--)
    {
        matrix[i, 0] = value;
        value++;
    }
    int k = 1;
    int m = 1;
    while (value < row * column)
    {
        while (matrix[k, m + 1] == 0)
        {
            matrix[k, m] = value;
            value++;
            m++;
        }
        while (matrix[k + 1, m] == 0)
        {
            matrix[k, m] = value;
            value++;
            k++;
        }
        while (matrix[k, m - 1] == 0)
        {
            matrix[k, m] = value;
            value++;
            m--;
        }
        while (matrix[k - 1, m] == 0)
        {
            matrix[k, m] = value;
            value++;
            k--;
        }
    }
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (matrix[i,j] == 0)
            {
                matrix[i,j] = value;
            }
        }
    }
                return matrix;
            }
// int[,] Generate4x4SpiralMatrixInt(int rows, int columns, int value)
// {
//     int[,] matrix = new int[rows, columns];
//     int row = matrix.GetLength(0);
//     int column = matrix.GetLength(1);
//     for (int j = 0; j < column; j++)
//     {
//         matrix[0, j] = value;
//         value++;
//     }
//     for (int i = 1; i < row; i++)
//     {
//         matrix[i, 3] = value;
//         value++;
//     }
//     for (int j = 2; j >= 0; j--)
//     {
//         matrix[3, j] = value;
//         value++;
//     }
//     for (int i = 2; i > 0; i--)
//     {
//         matrix[i, 0] = value;
//         value++;
//     }
//     for (int j = 1; j < 3; j++)
//     {
//         matrix[1, j] = value;
//         value++;
//     }
//     for (int j = 2; j > 0; j--)
//     {
//         matrix[2, j] = value;
//         value++;
//     }
//     return matrix;
// }


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine();
    }
}

// int[,] matr = Generate4x4SpiralMatrixInt(4, 4, 1);
int[,] matr = GenerateSpiralMatrixInt(4, 4, 1);
PrintMatrix(matr);

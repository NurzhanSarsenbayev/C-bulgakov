// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.



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
void SwitchFirstLastRow(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
       int temp = matrix[0,i];
       matrix[0,i] = matrix[matrix.GetLength(0)-1,i];
       matrix[matrix.GetLength(0)-1,i] = temp;
    }
}

int[,] matr = GenerateMatrixRndInt(3,3,0,6);
PrintMatrix(matr);
Console.WriteLine();
SwitchFirstLastRow(matr);
PrintMatrix(matr);

// void StringReplacement(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         int temp = matrix[0,i];
//         matrix[0,i] = matrix[matrix.GetLength(0)-1,i];
//         matrix[matrix.GetLength(0)-1,i] = temp;
//     }
// }

// int[,] matrix2 = GenerateMatrix(3,4,0,9);
// PrintMatrix(matrix2);
// Console.WriteLine();
// StringReplacement(matrix2);
// PrintMatrix(matrix2);
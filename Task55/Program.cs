// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


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

bool IsSquareMatrix(int[,] matrix)
{
    return (matrix.GetLength(0)==matrix.GetLength(1));
}
int[,] SwitchRowsAndColumns(int[,] matrix)
{
    int[,] temp=new int[matrix.GetLength(0),matrix.GetLength(1)];
    for (int i = 0; i <matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
             temp[j,i] = matrix[i,j];
        }
    }
    return temp;
}

int[,] matr = GenerateMatrixRndInt(3,4,0,6);
PrintMatrix(matr);
if(IsSquareMatrix(matr))
{
Console.WriteLine();
int[,] switchMatrix=SwitchRowsAndColumns(matr);
PrintMatrix(switchMatrix);
}
else Console.WriteLine("Invalid Matrix");
// int[,] ReplacingRowsWithColumns(int[,] matrix)
// {
//     int[,] mtx = new int[matrix.GetLength(0), matrix.GetLength(0)];
//     if (matrix.GetLength(0) != matrix.GetLength(1)) Console.WriteLine("Действие невозмжно");
//     else
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 mtx[j, i] = matrix[i, j];
//             }
//         }
//     }
//     return mtx;
// }

// int[,] matrix2 = GenerateMatrix(4, 4, 0, 9);
// PrintMatrix(matrix2);
// Console.WriteLine();
// int[,] replacingRowsWithColumns = ReplacingRowsWithColumns(matrix2);
// PrintMatrix(replacingRowsWithColumns);

// void ChangeRowsOnColumns(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0) - 1; i++)
//     {
//         for (int j = i + 1; j < matrix.GetLength(1); j++)
//         {
//             int temporary = matrix[i, j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = temporary;
//         }
//     }
// }
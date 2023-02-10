// *Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
int[,,] Generate3DMatrixRndInt(int rows, int columns, int depth, int value)
{
    int[,,] matrix = new int[rows, columns, depth];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = value;  // это конечно не случайный генератор, но по условию надо 
                value++;                  // было просто неповторяющиеся двузначные числа.
            }
        }
    }
    return matrix;
}
void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k <  matrix.GetLength(2); k++)
            {
                Console.Write($"   {matrix[i, j, k]}");
                Console.Write($"{(i, j, k)}");
            }
           
        }
        Console.WriteLine();
    }
}
int[,,] matr = Generate3DMatrixRndInt(2, 2, 2, 10);
Print3DMatrix(matr);
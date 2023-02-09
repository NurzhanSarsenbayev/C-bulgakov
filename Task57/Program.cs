// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


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
int[] ConvertMatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}
int[,] FrequencyVocabulary(int[] array)
{
    int rowCounter = 1;
    for (int k = 1; k < array.Length; k++)
    {
        if (array[k] != array[k - 1]) rowCounter++;
    }
    int[,] vocabulary = new int[rowCounter, 2];
    int m = 0;
    int vocabularyCounter = 1;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] != array[i + 1])
        {
            vocabulary[m, 0] = array[i];
            vocabulary[m, 1] = vocabularyCounter;
            m++;
            vocabularyCounter = 1;
        }
        else
        { vocabularyCounter++; }
        vocabulary[m, 0] = array[array.Length - 1];
        vocabulary[m, 1] = vocabularyCounter;
    }
    return vocabulary;
}


int[,] matr = GenerateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(matr);
int[] arr = ConvertMatrixToArray(matr);
Console.WriteLine();
PrintArray(arr);
Array.Sort(arr);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();
int[,] arr1 = FrequencyVocabulary(arr);
Console.WriteLine();
PrintMatrix(arr1);
//Array.Sort()


//  for (int m = 1; m < 4; m++)
//            {
//             //   Console.WriteLine($"m = {array[m]} != m+1 = {array[m+1]}");
//               if (array[m] == array[m + 1]) vocabulary[i, 0] = array[m];
//            }
//             // if (array[m] != array[m + 1])
//             //     {
//             //         Console.WriteLine($"m = {array[m]} != m+1 = {array[m+1]}");
//             //         vocabulary[i, 0] = array[m];
//             //         m++;
//     }
//     else Console.WriteLine($" m = {array[m]} = m+1 = {array[m+1]}");
// }
// int j = 0;
// for (int i = 0; i < rowCounter-1; i++)
// {
//     if(array[j]== array[j+1])
//     j++;
//     else vocabulary[i,0] = array[j];
// }

// int valueCount = 1;
// vocabulary[0, 0] = array[0];
// for (int i = 0; i < rowCounter; i++)
// {
//     if (vocabulary[i, 0] == vocabulary[i + 1, 0])
//     {
//         valueCount++;
//     }
//     vocabulary[i, 1] = valueCount;
// }









// void GetSameCountNubers(int[] arr)
// {
//     int tmp = arr[0];
//     int rowCounter = 1;
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (tmp == arr[i]) rowCounter++;
//         else
//         {
//             Console.WriteLine($"{tmp} - {rowCounter}");
//             tmp = arr[i];
//             rowCounter = 1;
//         }
//     }
//     Console.WriteLine($"{tmp} - {rowCounter}");
// }

// int[,] matrixNumbers = GenerateMatrix(3, 4, 0, 10);
// Console.WriteLine(PrintMatrix(matrixNumbers));

// int[] array = MatrixToArray(matrixNumbers);
// Array.Sort(array);
// Console.WriteLine(PrintArray(array));


// GetSameCountNubers(array);
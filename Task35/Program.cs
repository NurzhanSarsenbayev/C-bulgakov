﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int[] GenerateArray(int size, int min, int max)
{
int[] array = new int[size];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(min, max+1);
}
return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i< array.Length-1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int SearchCount(int[] array, int min, int max)
{
    int count=0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i]<=max) count++;  
    }
    return count;
}
int[] arr = GenerateArray(15,0,100);
PrintArray(arr);
int searchCount = SearchCount(arr,10,99);
Console.Write($" -> {searchCount}");
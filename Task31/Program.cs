﻿// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.


int[] CreateArrayRndInt(int arrSize, int min, int max)
{
    int[] array = new int[arrSize];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= rnd.Next(min,max+1);
    }
    return array;
}
void PrintArray(int[] array)
{
   Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    if(i<array.Length - 1) Console.Write($"{array[i]}, ");
    else Console.Write($"{array[i]}");
}
Console.WriteLine("]");
}
int GetSumNegativeElem (int[]array)
{
    int sum = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<0) sum+= array[i]; //sum = sum +array[i]
    }
    return sum;
}
int GetSumPositiveElem (int[]array)
{
    int sum = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) sum+= array[i]; //sum = sum +array[i]
    }
    return sum;
}
int[] GetSumPositiveNegativeElem(int[] array)
{
    int sumNegative= default;
    int sumPositive = default;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] !=0)
        {
        if (array[i]>0) sumPositive+= array[i]; 
        if (array[i]<0) sumNegative+= array[i]; 
        }
    }
    return new int[]{sumPositive, sumNegative}; 
}


int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int sumNegativeElem = GetSumNegativeElem(arr);
int sumPositiveElem = GetSumPositiveElem(arr);
Console.WriteLine($"Sum of positive elements in given array is {sumPositiveElem}");
Console.WriteLine($"Sum of negative elements in given array is {sumNegativeElem}");
Console.WriteLine("");
int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(arr);
Console.WriteLine($"Sum of positive elements in given array is {sumPositiveNegativeElem[0]}");
Console.WriteLine($"Sum of negative elements in given array is {sumPositiveNegativeElem[1]}");
﻿// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] GenerateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max - 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
        }
Console.WriteLine("]");
}

bool FindNumber(int[] array, int num)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        if (i == num) return true;
       
    }
    return false;
}


int[] arr = GenerateArray(4,-4,4);
PrintArray(arr);
Console.WriteLine("Type your number ");
int number = Convert.ToInt32(Console.ReadLine());
bool findnumber = FindNumber(arr,number);
string result = findnumber ? "yes" : "no";
Console.Write ($"{result}");
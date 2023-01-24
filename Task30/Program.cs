

// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// void FillArray(int[] array)
// {
//     int length = array.Length;
//     int index = 0;
//     while (index < length)
//     {
//         array[index] = new Random().Next(0, 2);
//         index++;
//     }
// }

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write($"{array[position]} ");
//         position++;
//     }
// }

// int[] arrayOne = new int[8];
// FillArray(arrayOne);
// PrintArray(arrayOne);




int[] GenerateArray(int arraysize,int min,int max)
{
    int[] arr = new int[arraysize];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max+1);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} " );
    }
}

Console.WriteLine("Type in size of your array ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type in minimum value of your array ");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type in maximum value of your array ");
int maximum = Convert.ToInt32(Console.ReadLine());
int [] array = GenerateArray(size, minimum, maximum);
PrintArray(array);
// Random rnd = new Random()

// int[] GenerateArray(int size,int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random(); 
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} " );
//     }
// }

// int [] array = GenerateArray(8, 0, 1);
// PrintArray(array);





// int[] array = new int[8];
// int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
// int[] array2 = { 1, 2, 3 };
// var array3 = new int[8];

// array[0] = 123;
// array[1] = 5654;
// array[2] = 43;
// array[3] = 5;
// array[4] = 32;
// array[5] = 7;
// array[6] = 4;
// array[7] = 32;
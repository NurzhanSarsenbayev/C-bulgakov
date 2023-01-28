// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GenerateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
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

int[] MultArray(int[] array)
{

   int size = array.Length /2;
    if (array.Length %2 == 1) size+=1;
     int[] arrayNew = new int[size];
        for (int i = 0; i < size; i++)
        {
            arrayNew[i] = array[i] * array[array.Length - 1 - i];
           
            
        } 
         if (array.Length % 2 == 1) arrayNew[arrayNew.Length - 1] = array[array.Length / 2];
        return arrayNew;
}

int[] arr = GenerateArray(5, 1, 9);
PrintArray(arr);
int[] multArray = MultArray(arr);
Console.Write(" - >  ");
PrintArray(multArray);


// int[] ArrayProductNumberFirstLast(int[] array)
// {
//     int size = array.Length / 2;
//     if (array.Length % 2 == 1) size += 1;
    
//     int[] arrayNew = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         arrayNew[i] = array[i] * array[array.Length - 1 - i];
//     }

//     if (array.Length % 2 == 1) arrayNew[arrayNew.Length - 1] = array[array.Length / 2];
//     return arrayNew;
// }


// double[] CreateArrayRndDouble(int size, int min, int max)
// {
//     double[] array = new double[size];
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.NextDouble() * (max - min) + min;
//     }
//     return array;
// }

// void PrintArrayDouble (double[] array) 
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.WriteLine("]");
// }

// int[] GreatArrayRnd(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }
// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}]");
//     }
// }
// int[] ArrayProductNumberFirstLast(int[] array)
// {
//     int size = array.Length / 2;
//     if (array.Length % 2 == 1) size += 1;
    
//     int[] arrayNew = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         arrayNew[i] = array[i] * array[array.Length - 1 - i];
//     }

//     if (array.Length % 2 == 1) arrayNew[arrayNew.Length - 1] = array[array.Length / 2];
//     return arrayNew;
// }

// int[] arr = GreatArrayRnd(5, 0, 10);
// PrintArray(arr);

// int[] arrNew = ArrayProductNumberFirstLast(arr);
// PrintArray(arrNew);
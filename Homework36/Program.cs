// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0




//  Закомментировано понастоящему рандомный вариант решения. 
//  Учитывая размеры чисел, решил сделать пример более легким для проверки



// int[] GenerateArray(int size)    
int[] GenerateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max-1);
        // array[i] = rnd.Next();
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i<array.Length-1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int SumNumbersInOddOrder(int[] array)
{
    int sum = default;
    for (int i = 0; i < array.Length; i++)
    {
        if(i%2==1) sum+=array[i] ;
    }
    return sum;
}
int[] arr = GenerateArray(5,-10,10);
// int[] arr = GenerateArray(5);
PrintArray(arr);
int sumNumbersInOddOrder = SumNumbersInOddOrder(arr);
Console.Write($" -> {sumNumbersInOddOrder}");
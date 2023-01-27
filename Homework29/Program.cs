// 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//  1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] GenerateArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 99);  // для простоты, а так можно оставить пустым и будут большие числа
    }
    return arr;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length-1]} -> [");

    //Что бы получилось, как в примере. Чувствую, чо есть способ проще, но не смог его сам сделать. 
}

void PrintArray2(int[] arr)
{
for (int i = 0; i < arr.Length-1; i++)
{
    
    Console.Write($"{arr[i]}, ");
   
}
 Console.Write($"{arr[arr.Length-1]}]");
}
int[] array = GenerateArray(5);
PrintArray(array);
PrintArray2(array);


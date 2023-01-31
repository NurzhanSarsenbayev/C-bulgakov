// // Задача 42: Напишите программу, которая будет преобразовывать
// // десятичное число в двоичное.
// // 45 -> 101101
// // 3 -> 11
// // 2 -> 10

int BinaryNumber(int num)
{
    int res = 0;
    int count = 1;
    while (num > 0)
    {
        res += num % 2 * count;
        Console.WriteLine($"res is {res}");
        num /= 2;
        Console.WriteLine($"num is {num}");
        count *= 10;
        Console.WriteLine($"count is {count}");
    }
    return res;
}

Console.WriteLine("Type your number ");
int number = Convert.ToInt32(Console.ReadLine());
int binary = BinaryNumber(number);
Console.WriteLine($"Binary value of {number} is {binary}");



string DecToBin(int num)
{
    string result = string.Empty;
    while (num > 0)
    {        
        result = num % 2 + result;
        num = num /2;
    }

    return result;
}


Console.Write("Введите десятичное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

string decToBin = DecToBin(number1);

Console.Write(number1);
Console.Write(" -> ");
Console.Write(decToBin);




// using System;  
//   public class ConversionExample  
//    {  
//      public static void Main(string[] args)  
//       {  
//        int  n, i;       
//        int[] a = new int[10];     
//        Console.Write("Enter the number to convert: ");    
//        n= int.Parse(Console.ReadLine());     
//        for(i=0; n>0; i++)      
//         {      
//          a[i]=n%2;      
//          n= n/2;    
//         }      
//        Console.Write("Binary of the given number= ");      
//        for(i=i-1 ;i>=0 ;i--)      
//        {      
//         Console.Write(a[i]);      
//        }                 
//       }  
//   }  
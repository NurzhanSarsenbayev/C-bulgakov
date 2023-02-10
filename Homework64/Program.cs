// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// // N = 5 -> "5, 4, 3, 2, 1"
// // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void AllNumbersFromNumToOne (int num)
{

if (num==0) return;
Console.Write($"{num} ");
   AllNumbersFromNumToOne(num-1);
}


Console.WriteLine("Type in number N");
int number= Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {number} -> \" ");
AllNumbersFromNumToOne(number);
Console.Write('"');














// // void Swap(int num1, int num2)
// // {
// //     int tmp;
// //     tmp = num1;
// //     num1 = num2;
// //     num2= tmp;
// //     Console.WriteLine($"{num1} , {num2}");   
// // }

// // Console.WriteLine("Type in your number");
// // int number1 = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Type in your number");
// // int number2 = Convert.ToInt32(Console.ReadLine());
// // Swap(number1, number2);
// // Console.WriteLine($"{number1} , {number2}");

// // Swap(number1, number2);

// int SwapTwoNumbers (int num1, int num2)
// {
//     int tmp = num1;
//     num1 = num2;
//     num2 = tmp;
//     return num1;
//     return num2;
// }

// int SumElements (int numM, int numN)
// {
 
//     return numM == numN+1? 0 : numM+SumElements(numM+1, numN);
// }

// Console.WriteLine("Введите первое число");
// int numberM = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int numberN = Convert.ToInt32(Console.ReadLine());
// int sumElements=default;
//    if(numberM>numberN)
//     {
//         SwapTwoNumbers(numberM,numberN);
//        sumElements = SumElements(numberM,numberN);
//     }
// sumElements = SumElements(numberM,numberN);
// Console.WriteLine(sumElements);
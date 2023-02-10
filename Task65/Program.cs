// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void FromMtoN(int num1, int num2)
{
    Console.Write($"{num1} ");
    if (num1 == num2) return;
    if (num1 < num2)
    {
        FromMtoN(num1 + 1, num2);
    }
    if (num1 > num2)
    {
        FromMtoN(num1-1, num2); 
    }
}
Console.WriteLine("Type your number m");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type your number n");
int number2 = Convert.ToInt32(Console.ReadLine());
FromMtoN(number1, number2);
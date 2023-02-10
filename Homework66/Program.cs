// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//  Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumFromMtoN(int num1, int num2)
{
    int sum = default;
    while (num1 != num2)
    {
        if (num1 < num2)
        {
            SumFromMtoN(num1 + 1, num2);
            sum += num1;
            num1++;
        }
        if (num1 > num2)
        {
            SumFromMtoN(num1-1, num2);
            sum += num1;
            num1--;
        }
    }
    sum += num1;
    return sum;
}
Console.WriteLine("Type your number m");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type your number n");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = SumFromMtoN(number1, number2);
Console.WriteLine($"M = {number1}; N = {number2} -> {result}");
// 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//  452 -> 11
//  82 -> 10
//  9012 -> 12

int SumResult(int num)
{
    int digit = 0;
    int sum = 0;
    while (num > 0)
    {
        digit = num % 10;
        sum = sum + digit;
        num = num / 10;
    }
    return sum;
}


Console.WriteLine("Type your number ");
int number = Convert.ToInt32(Console.ReadLine());
int sumResult = SumResult(number);
Console.WriteLine($"{number} -> {sumResult}");
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 

// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigitRecognizer(int arg1)
{
    int twoDigits = arg1 % 100;
    int oneDigit = twoDigits / 10;
    return oneDigit;
}

Console.WriteLine("Type your three digit number");

int number1 = Convert.ToInt32(Console.ReadLine());


if (number1 > 100 && number1 < 1000 || number1 < -100 && number1 > -1000)
{
    int result = SecondDigitRecognizer(number1);
    if (result>0)
    Console.WriteLine($"{result}");
    
    else
    {
        result = result*-1;
    Console.WriteLine($"{result}");
    }
}
else Console.WriteLine("Invalid number");
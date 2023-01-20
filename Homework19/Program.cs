// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да



bool Palindrome(int num)
{
    int num1;
    int num2;
    int num3;

    // while (num > 10)                           Это пробный код был, не работал потому что num постоянно менялся.
    //     num = num / 10;                        В последующем я просто поменял расстановку действий.
    // }
    // num1 = num % 10;
    // num2 = (num % 100) / 10;
    // while (num > 100)
    // {
    //     num = num / 10;
    // }
    // num3 = num % 10;
    if (num < 0) num = num * -1;
    num1 = num % 10;
    num2 = (num % 100) / 10;
    while (num > 100)
    {
        num = num / 10;
    }
    num3 = num % 10;
    while (num > 10)
    {
        num = num / 10;
    }
    if (num3 == num2 && num == num1) return true;
    return false;
}



Console.WriteLine("Type your five-digit number :");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 10000 && number < 99999 || number < -10000 && number > -99999)
{
    bool palindrome = Palindrome(number);
    string result = palindrome ? "yes" : "no";
    Console.WriteLine(result);
}
else Console.WriteLine("InvalidNumber");
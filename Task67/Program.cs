// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// double Factorial(int n)
// {
//     //1!=1
//     //0!=1
//     if(n==1) return 1;
//     else return n*Factorial(n-1);
// }
// for (int i = 1; i < 40; i++)
// {
// Console.WriteLine($"{i}! = {Factorial(i)}");
// }

int SumofNumbers(int num)
{
    int sum=default;
    if(num>9)
    {
        sum = SumofNumbers(num/10)+num%10;
        return sum;
    }
    else return num;
}

Console.WriteLine("type your number");
int number = Convert.ToInt32(Console.ReadLine());
int sumNum = SumofNumbers(number);
Console.WriteLine(sumNum);


// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());


// if (number < 0) number = number*(-1);
// int summ = SumOfDigits(number);
// Console.WriteLine(summ);


// int SumOfDigits(int num)
// {
//     int sum = default;
//     if (num > 9)
//     {
//         sum = SumOfDigits(num / 10) + num%10;
//         return sum;
//     }
//     else
//         return num;
// }
// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Random number from 10 - 99 => {number}");

// int firstDigit = number / 10; //first digit
// int secondDigit = number % 10;
// if (firstDigit > secondDigit) Console.WriteLine($"Bigger digit of {number} => {firstDigit}");
// else Console.WriteLine($"Bigger digit of {number} => {secondDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"{number} => {maxDigit}");


int MaxDigit(int num)
{
    int firstDigit = num / 10; //first digit
    int secondDigit = num % 10;
    if (firstDigit > secondDigit) return firstDigit;
    else return secondDigit;
}
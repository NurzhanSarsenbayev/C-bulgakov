//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Type first number ");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Type second number ");
double numberB = Convert.ToDouble(Console.ReadLine());
double maxNumber = numberA;
double minNumber = numberB;
if (numberA > numberB)
{
    maxNumber = numberA;
    minNumber = numberB;
    Console.WriteLine($"a = {numberA}; b= {numberB} -> {maxNumber} > {minNumber}");
}
else
{
    maxNumber = numberB;
    minNumber = numberA;
    Console.WriteLine($"a = {numberA}; b = {numberB} -> {maxNumber} > {minNumber}");

};

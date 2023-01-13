//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Type first number ");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Type second number ");
double numberB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Type third number ");
double numberC = Convert.ToDouble(Console.ReadLine());

double maxnumber = numberA;

if (numberA > maxnumber) maxnumber=numberA;
if (numberB > maxnumber) maxnumber=numberB;
if (numberC > maxnumber) maxnumber=numberC;
Console.WriteLine($"{numberA}, {numberB}, {numberC} -> {maxnumber}");
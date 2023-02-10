// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int NumberToDegree()

// Console.WriteLine("type your number");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("type your second number");
// int number2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("введите число ");
int numA = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("введите число ");
int numB = Convert.ToInt32(Console.ReadLine());

int prodactNumbersAB = ProdactNumbersAB(numA, numB);
Console.WriteLine($"число {numA} в целую степень {numB} равно {prodactNumbersAB}");


int PowerRec (int numberA, int numberB)
{
    return numberB == 0 ? 1 : PowerRec (numberA, numberB - 1) * numberA;
    
}

int ProdactNumbersAB(int numberA, int numberB)
{
    if (numberB == 0) return 1;
    if (numberB % 2 == 0) return ProdactNumbersAB (numberA * numberA, numberB/2);
    return PowerRec (numberA, numberB - 1) * numberA;
}
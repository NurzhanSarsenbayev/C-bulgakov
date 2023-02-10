// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermannFunction(int num1, int num2)
{
    if (num1 == 0)
        return num2 + 1;
    else
      if ((num1 != 0) && (num2 == 0))
        return AckermannFunction(num1 - 1, 1);
    else
        return AckermannFunction(num1 - 1, AckermannFunction(num1, num2 - 1));
}

int ackermannFunction = AckermannFunction(3, 2);
Console.WriteLine($"m=2 n=3  ->  {ackermannFunction}");
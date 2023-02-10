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

Console.WriteLine("Type in your first number");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type in your first number");
int number2 = Convert.ToInt32(Console.ReadLine());
int ackermannFunction = AckermannFunction(number1, number2);
Console.WriteLine($"m = {number1} , n = {number2}  ->  {ackermannFunction}");
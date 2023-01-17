// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

bool Square(int arg1, int arg2)
{
    return arg1 * arg1 == arg2 || arg2 * arg2 == arg1;
}

Console.WriteLine("Type two numbers");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

bool square = Square(num1, num2);
if (square)  Console.WriteLine("Yes");
else Console.WriteLine("No");
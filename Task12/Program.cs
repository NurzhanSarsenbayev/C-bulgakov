// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int Multi(int arg1,int arg2)
{
return arg1 % arg2;

}

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = Multi (num1, num2);
if (result==0) Console.WriteLine("кратно");
else Console.WriteLine($"не кратно, остаток {result} ");
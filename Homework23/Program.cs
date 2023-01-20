// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



void Square(int number)
{
for (int count=1; count<=number; count++)
{
 
   Console.WriteLine($"{count,5}    ->{count*count*count,5}");
}
}


Console.WriteLine("Type your number");
int num = Convert.ToInt32(Console.ReadLine());
if (num<1)
{
    Console.WriteLine("Invalid input");
}
Square(num);

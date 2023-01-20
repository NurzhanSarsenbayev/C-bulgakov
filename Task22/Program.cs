// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void Square(int number)
{
for (int count=1; count<=number; count++)
{
 
   Console.WriteLine($"{count,5}    ->{count*count,5}");
}
}


Console.WriteLine("Type your number");
int num = Convert.ToInt32(Console.ReadLine());
if (num<1)
{
    Console.WriteLine("Invalid input");
}
Square(num);

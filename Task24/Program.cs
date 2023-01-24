// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int AddNumber(int num)
{
    int sum = 0;
  for(int i = 0; i<=num; i++)
  {
     
     sum+=i;
  }
  return sum;
}

Console.WriteLine("Type your positive natural number ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>0)
{
int result = AddNumber(number);
Console.WriteLine($"{number} -> {result}");
}
else Console.WriteLine("Invalid number");

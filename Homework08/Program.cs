//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8


Console.WriteLine("Type your natural number ");
int numberA = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (numberA > 0)
{
    Console.Write($"{numberA} -> ");
    while (count <= numberA)
    {
        
        Console.Write($"{count} ");
        count = count + 2;
    }


}
else
{
    Console.WriteLine("Invalid number");
};
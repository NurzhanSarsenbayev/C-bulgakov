//5. Напишите программу, которая на вход принимает
//одно число (N), а на выходе показывает все целые
//числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Type your natural number ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA > 0)

{
    int count = -numberA;


    while (count <= numberA)
    {
      
        Console.Write($"{count} ");
        count ++;
    }
}
else
{
    Console.WriteLine("Invalid number");
}


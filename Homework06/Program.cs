//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Type your number to determine if it's even or odd ");
int numberA=Convert.ToInt32(Console.ReadLine());
if (numberA%2 == 0)
{
    Console.WriteLine($"{numberA} -> even");
}
else{
    Console.WriteLine($"{numberA} -> odd");
}